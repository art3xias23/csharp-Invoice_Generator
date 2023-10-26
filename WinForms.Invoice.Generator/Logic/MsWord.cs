using DocumentFormat.OpenXml.Wordprocessing;
using OfficeIMO.Word;
using WinForms.Invoice.Generator.Data;
using WinForms.Invoice.Generator.Structure;

namespace WinForms.Invoice.Generator.Logic
{
    internal class MsWord
    {
        private readonly Data.Invoice _data;
        internal MsWord(Data.Invoice data)
        {
            _data = data;
        }

        internal void CreateDocument()
        {
            var fileName = CreateFileName();
            if (_data.DocumentType == Enums.DocumentType.Invoice)
            {

                SetSaveLocationDialog(fileName, SingletonData.Instance.InvoiceData.InvoiceDirectory);
            }
            else if (_data.DocumentType == Enums.DocumentType.Quote)
            {

                SetSaveLocationDialog(fileName, SingletonData.Instance.InvoiceData.QuoteDirectory);
            }
            var filePath = GetFilePath();
            var fullFilePath = Path.Combine(filePath, fileName);
            using WordDocument document = WordDocument.Create(fullFilePath);

            document.Sections[0].PageOrientation = PageOrientationValues.Landscape;

            switch (_data.DocumentType)
            {
                case Enums.DocumentType.Invoice:
                    CreateInvoice(document);
                    break;
                case Enums.DocumentType.Quote:
                    CreateQuote(document);
                    break;
                default:
                    MessageBox.Show("No Document Type Has been Selected");
                    break;
            }

            document.Save();
            document.Open(filePath);
        }

        private void SetSaveLocationDialog(string fileName, string filePath)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = fileName; // Set your default filename

            saveFileDialog.InitialDirectory = filePath;
            // Set the file filter (optional)
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            // Show the Save File Dialog
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                switch (_data.DocumentType)
                {
                    case Enums.DocumentType.Invoice:
                         filePath = Path.GetDirectoryName(saveFileDialog.FileName);
                        SingletonData.Instance.InvoiceData.InvoiceDirectory =filePath ;
                         
                        break;
                    case Enums.DocumentType.Quote:
                         filePath = Path.GetDirectoryName(saveFileDialog.FileName);
                        SingletonData.Instance.InvoiceData.QuoteDirectory = filePath;
                        break;
                }
            }
        }

        private string GetFilePath()
        {
            switch (_data.DocumentType)
            {
                case Enums.DocumentType.Invoice:
                    return SingletonData.Instance.InvoiceData.InvoiceDirectory;
                case Enums.DocumentType.Quote:
                    return SingletonData.Instance.InvoiceData.QuoteDirectory;
                    default:
                        return "";
            }
        }

        private void CreateInvoice(WordDocument document)
        {
            document.Sections[0].PageOrientation = PageOrientationValues.Landscape;

            document.AddParagraph("Date: " + DateTime.Now.ToString("dd/MM/yyyy"));

            document.AddParagraph();

            AddFirmInfo(document, _data.OriginFirm);

            document.AddParagraph();


            AddFirmInfo(document, _data.TargetFirm);

            document.AddParagraph();

            document.AddParagraph($"Invoice: {_data.InvoiceId:D10}");

            document.AddParagraph();

            document.AddParagraph(_data.InvoiceParagraph1.Replace("{target_name_placeholder}", _data.TargetFirm.Name));
            document.AddParagraph(_data.InvoiceParagraph2.Replace("{origin_firm_placeholder}", _data.OriginFirm.Name));

            document.AddParagraph();

            document.AddParagraph(_data.InvoiceParagraph3
                .Replace("{hours_placeholder}", _data.HoursPerDay.ToString())
                .Replace("{days_placeholder}", _data.WorkingDays.Where(x=>x.IsWorkingDay).ToList().Count.ToString())
                .Replace("{per_hour_payment}", _data.HourlyPayment.ToString())
                .Replace("{currency_placeholder}", _data.Currency)
                .Replace("{total_amount_placeholder}", GetTotalAmountPayable(_data)?.ToString()));

            document.AddParagraph();

            document.AddHorizontalLine();
            var table = document.AddTable(_data.WorkingDays.Count, 6, WordTableStyle.GridTable1Light);
            var workingDayCount = -1;
            var totalPaymentCount = 0M;

            document.AddParagraph(_data.InvoiceParagraph4);

            document.AddParagraph();

            AddHourTable(table);

            document.AddParagraph();

            document.AddParagraph(_data.InvoiceParagraph5);

            document.AddParagraph();

            AddBankInfo(document);

            document.AddParagraph();
            document.AddParagraph(_data.InvoiceParagraph6);
            document.AddParagraph(_data.OriginFirm.PhoneNumber);
            document.AddParagraph("OR");

            document.AddParagraph(_data.OriginFirm.EmailAddress);
            document.AddParagraph();

            document.AddParagraph(_data.InvoiceParagraph7);
            document.AddParagraph();
            document.AddParagraph("Sincerely,");
            document.AddParagraph(_data.OriginFirm.Name);
        }

        private void AddBankInfo(WordDocument document)
        {
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
        }

        private void AddFirmInfo(WordDocument document, Firm firmData)
        {
            document.AddParagraph(firmData.Name).Bold = true;
            document.AddParagraph($"{firmData.Address.AddressLine1}");
            document.AddParagraph($"{firmData.Address.AddressLine2}");
            document.AddParagraph($"{firmData.Address.City}");
            document.AddParagraph($"{firmData.Address.Country}");
            document.AddParagraph($"{firmData.Address.Postcode}");
            document.AddParagraph($"{firmData.PhoneNumber}");
            document.AddParagraph($"{firmData.EmailAddress}");
        }

        internal void CreateQuote(WordDocument document)
        {
            document.AddParagraph("Date: " + DateTime.Now.ToString("dd/MM/yyyy"));

            document.AddParagraph();
            AddFirmInfo(document, _data.OriginFirm);

            document.AddParagraph();

            AddFirmInfo(document, _data.TargetFirm);
            document.AddParagraph();

            document.AddParagraph($"Invoice: {_data.QuoteId:D10}");
            document.AddParagraph();

            document.AddParagraph(_data.QuoteParagraph1.Replace("{target_name_placeholder}", _data.TargetFirm.Name));
            document.AddParagraph(_data.QuoteParagraph2.Replace("{mm_yyyy_placeholder}", DateTime.Now.AddMonths(1).ToString("MM-yyyy")));

            document.AddParagraph();

            document.AddParagraph(_data.QuoteParagraph3
                .Replace("{hours_placeholder}", _data.HoursPerDay.ToString())
                .Replace("{days_placeholder}", _data.WorkingDays.Where(x=>x.IsWorkingDay).ToList().Count.ToString())
                .Replace("{per_hour_payment}", _data.HourlyPayment.ToString())
                .Replace("{currency_placeholder}", _data.Currency)
                .Replace("{total_amount_placeholder}", GetTotalAmountPayable(_data)?.ToString()));

            document.AddParagraph();

            document.AddHorizontalLine();
            var table = document.AddTable(_data.WorkingDays.Count, 6, WordTableStyle.GridTable1Light);

            AddHourTable(table);

            document.AddParagraph();

            document.AddParagraph(_data.QuoteParagraph4);

            document.AddParagraph(_data.OriginFirm.PhoneNumber);
            document.AddParagraph("OR");
            document.AddParagraph(_data.OriginFirm.EmailAddress);


            document.AddParagraph(_data.QuoteParagraph5);
            document.AddParagraph();
            document.AddParagraph("Sincerely,");
            document.AddParagraph(_data.OriginFirm.Name);
        }

        private void AddHourTable(WordTable table)
        {
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
        }

        private decimal? GetTotalAmountPayable(Data.Invoice data)
        {
            return data.HoursPerDay * data.WorkingDays.Where(x=>x.IsWorkingDay).ToList().Count * data.HourlyPayment;
        }

        private string CreateFileName()
        {
            string fileName = string.Empty;

            switch (_data.DocumentType)
            {
                case Enums.DocumentType.Invoice:
                    fileName=$"{DateTime.Now:yyMM}_Invoice_{_data.OriginFirm.Name.Replace(" ", "_")}";
                    break;
                case Enums.DocumentType.Quote:
                    fileName=$"{DateTime.Now.AddMonths(1):yyMM}_Quote_{_data.OriginFirm.Name.Replace(" ", "_")}";
                    break;
            }
            fileName = Path.ChangeExtension(fileName, ".docx");

            return fileName;
        }
    }
}
