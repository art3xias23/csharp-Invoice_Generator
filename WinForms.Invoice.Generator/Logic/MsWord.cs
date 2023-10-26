using System.Text;
using DocumentFormat.OpenXml.Wordprocessing;
using OfficeIMO.Word;

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
                document.AddParagraph(_data.OriginFirm.Name);
                document.AddParagraph($"{_data.OriginFirm.Address.AddressLine1}");
                document.AddParagraph($"{_data.OriginFirm.Address.AddressLine2}");
                document.AddParagraph($"{_data.OriginFirm.Address.City}");
                document.AddParagraph($"{_data.OriginFirm.Address.Country}");
                document.AddParagraph($"{_data.OriginFirm.Address.Postcode}");
                document.AddParagraph($"{_data.OriginFirm.PhoneNumber}");
                document.AddParagraph($"{_data.OriginFirm.EmailAddress}");

                document.AddParagraph();

                document.AddParagraph(DateTime.Now.ToString("dd/MM/yyyy"));

                document.AddParagraph(_data.TargetFirm.Name);
                document.AddParagraph($"{_data.TargetFirm.Address.AddressLine1}");
                document.AddParagraph($"{_data.TargetFirm.Address.AddressLine2}");
                document.AddParagraph($"{_data.TargetFirm.Address.City}");
                document.AddParagraph($"{_data.TargetFirm.Address.Country}");
                document.AddParagraph($"{_data.TargetFirm.Address.Postcode}");
                document.AddParagraph($"{_data.TargetFirm.PhoneNumber}");
                document.AddParagraph($"{_data.TargetFirm.EmailAddress}");

                document.AddParagraph();

                document.AddParagraph("Invoice: 0000000004");

                document.AddParagraph();

                document.AddParagraph(_data.Paragraph1.Replace("{target_name_placeholder}", _data.TargetFirm.Name));
                document.AddParagraph(_data.Paragraph2.Replace("{origin_firm_placeholder}", _data.OriginFirm.Name));

                document.AddParagraph();

                document.AddParagraph(_data.Paragraph3
                    .Replace("{hours_placeholder}", _data.HoursPerDay.ToString())
                    .Replace("{days_placeholder}", _data.WorkingDays.Count.ToString()).Replace("{per_hour_payment}", _data.HourlyPayment.ToString())
                    .Replace("{currency_placeholder}", _data.Currency)
                    .Replace("{total_amount_placeholder}", GetTotalAmountPayable(_data)?.ToString()));

                document.AddParagraph();

                document.AddHorizontalLine();
                var table = document.AddTable(_data.WorkingDays.Count, 6, WordTableStyle.GridTable1Light);
                var workingDayCount = -1;
                var totalPaymentCount = 0M;

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

                document.AddParagraph(_data.Paragraph4);
                document.Save();
                document.Open(filePath);
            }
        }

        private decimal? GetTotalAmountPayable(Data.Invoice data)
        {
            return data.HoursPerDay * data.WorkingDays.Count * data.HourlyPayment;
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
