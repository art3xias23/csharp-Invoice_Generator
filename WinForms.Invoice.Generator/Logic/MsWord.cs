using System.Text;
using DocumentFormat.OpenXml.Wordprocessing;
using OfficeIMO.Word;

namespace WinForms.Invoice.Generator.Logic
{
    internal class MsWord
    {
        private readonly Data _data;
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
                    .Replace("{hours_placeholder}", _data.))
                
                document.Save();
                document.Open(filePath);
            }
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
