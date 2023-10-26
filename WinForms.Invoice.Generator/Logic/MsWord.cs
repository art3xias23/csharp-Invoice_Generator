using System.Text;
using DocumentFormat.OpenXml.Wordprocessing;
using OfficeIMO.Word;
using WinForms.Invoice.Generator.Data;

namespace WinForms.Invoice.Generator.Logic
{
    internal class MsWord
    {
        private readonly Data.Invoice _data;
        internal MsWord(Data.Invoice data)
        {
            _data = data;
        }

        internal void CreateInvoice()
        {
            var filePath = CreateTempFileName();
            using (WordDocument document = WordDocument.Create(filePath))
            {
                document.Sections[0].PageOrientation = PageOrientationValues.Landscape;
                AddFirmInfo(document, _data.OriginFirm);

                document.AddParagraph();

                document.AddParagraph(DateTime.Now.ToString("dd/MM/yyyy"));

                document.AddParagraph();

                AddFirmInfo(document, _data.TargetFirm);

                document.AddParagraph();

                document.AddParagraph("Invoice: 0000000004");

                document.AddParagraph();

                document.AddParagraph(_data.InvoiceParagraph1.Replace("{target_name_placeholder}", _data.TargetFirm.Name));
                document.AddParagraph(_data.InvoiceParagraph2.Replace("{origin_firm_placeholder}", _data.OriginFirm.Name));

                document.AddParagraph();

                document.AddParagraph(_data.InvoiceParagraph3
                    .Replace("{hours_placeholder}", _data.HoursPerDay.ToString())
                    .Replace("{days_placeholder}", _data.WorkingDays.Count.ToString()).Replace("{per_hour_payment}", _data.HourlyPayment.ToString())
                    .Replace("{currency_placeholder}", _data.Currency)
                    .Replace("{total_amount_placeholder}", GetTotalAmountPayable(_data)?.ToString()));

                document.AddParagraph();

                document.AddHorizontalLine();
                var table = document.AddTable(_data.WorkingDays.Count, 6, WordTableStyle.GridTable1Light);
                var workingDayCount = -1;
                var totalPaymentCount = 0M;

                document.AddParagraph(_data.InvoiceParagraph4);

                document.AddParagraph();

                AddHourTable(table, workingDayCount, totalPaymentCount);

                document.AddParagraph();

                document.AddParagraph(_data.InvoiceParagraph5);

                document.AddParagraph();
                document.AddParagraph($"Bank: {_data.OriginBankDetails.Bank}");
                document.AddParagraph($"Bank Address Line 1: {_data.OriginBankDetails.Address.AddressLine1}");
                document.AddParagraph($"Bank Address Line 2: {_data.OriginBankDetails.Address.AddressLine2}");
                document.AddParagraph($"Bank City: {_data.OriginBankDetails.Address.City}");
                document.AddParagraph($"Bank Country: {_data.OriginBankDetails.Address.Country}");
                document.AddParagraph($"Bank Postcode: {_data.OriginBankDetails.Address.Postcode}");
                document.AddParagraph();
                document.AddParagraph($"Beneficiary: {_data.OriginBankDetails.Beneficiary}");
                document.AddParagraph($"Bank Account: {_data.OriginBankDetails.BankAccount}");
                document.AddParagraph($"Sort Code: {_data.OriginBankDetails.SortCode}");
                document.AddParagraph();
                document.AddParagraph(_data.InvoiceParagraph6);
                document.AddParagraph(_data.OriginFirm.PhoneNumber);
                document.AddParagraph("OR");

                document.AddParagraph(_data.OriginFirm.EmailAddress);
                document.AddParagraph();

                document.AddParagraph(_data.InvoiceParagraph7);
                document.AddParagraph("Sincerely,");
                document.AddParagraph(_data.OriginFirm.Name);

                document.Save();
                document.Open(filePath);
            }
        }

              private void AddFirmInfo(WordDocument document, Firm firmData)
        {
            document.AddParagraph(_data.OriginFirm.Name).Bold = true;
            document.AddParagraph($"{firmData.Address.AddressLine1}");
            document.AddParagraph($"{firmData.Address.AddressLine2}");
            document.AddParagraph($"{firmData.Address.City}");
            document.AddParagraph($"{firmData.Address.Country}");
            document.AddParagraph($"{firmData.Address.Postcode}");
            document.AddParagraph($"{firmData.PhoneNumber}");
            document.AddParagraph($"{firmData.EmailAddress}");
        }

        internal void CreateQuote()
        {
                       
        }

        private void AddHourTable(WordTable table, int workingDayCount, decimal totalPaymentCount)
        {
            foreach (var row in table.Rows)
            {
                if (workingDayCount == -1)
                {
                    row.Cells[0].Paragraphs[0].Text = "Date";
                    row.Cells[1].Paragraphs[0].Text = "Day of Week";
                    row.Cells[2].Paragraphs[0].Text = "Holiday";
                    row.Cells[3].Paragraphs[0].Text = "Hours";

                    row.Cells[4].Paragraphs[0].Text = "Rate";

                    row.Cells[5].Paragraphs[0].Text = "SubTotal";
                    workingDayCount++;
                    continue;
                }

                var workingDay = _data.WorkingDays[workingDayCount];

                if (workingDay.IsWorkingDay)
                {
                    row.Cells[0].Paragraphs[0].Text = workingDay.Date.ToString("dd/MM/yyyy");
                    row.Cells[1].Paragraphs[0].Text = workingDay.Date.DayOfWeek.ToString();

                    row.Cells[2].Paragraphs[0].Text = string.Empty;

                    row.Cells[3].Paragraphs[0].Text = _data.HoursPerDay.ToString();

                    row.Cells[4].Paragraphs[0].Text = $"{_data.Currency}{_data.HourlyPayment}/hr";

                    totalPaymentCount = totalPaymentCount + (_data.HourlyPayment * _data.HoursPerDay);

                    row.Cells[5].Paragraphs[0].Text = totalPaymentCount.ToString();
                }
                else
                {
                    row.Cells[0].Paragraphs[0].Text = workingDay.Date.ToString("dd/MM/yyyy");

                    row.Cells[1].Paragraphs[0].Text = workingDay.Date.DayOfWeek.ToString();

                    if (workingDay.IsHoliday)
                    {
                        row.Cells[2].Paragraphs[0].Text = "✓";
                    }

                    row.Cells[3].Paragraphs[0].Text = "0";
                    row.Cells[4].Paragraphs[0].Text = $"{_data.Currency}{_data.HourlyPayment}/hr";

                    row.Cells[5].Paragraphs[0].Text = totalPaymentCount.ToString();
                }

                workingDayCount++;
            }
        }

        private decimal? GetTotalAmountPayable(Data.Invoice data)
        {
            return data.HoursPerDay * data.WorkingDays.Where(x=>x.IsWorkingDay).ToList().Count * data.HourlyPayment;
        }

        private string CreateTempFileName()
        {
            var tempDirectory = Path.GetTempPath();

            var tempFileName = Path.GetRandomFileName();

            var tempFilePath = Path.Combine(tempDirectory, tempFileName);

            return tempFilePath;
        }
    }
}
