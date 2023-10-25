using Newtonsoft.Json;

namespace WinForms.Invoice.Generator.Logic
{
    public  class JsonData
    {
        private static string? GetJson()
        {
            var json = File.ReadAllLines(@"..\..\Data.json");

            return json?.ToString();
        }

        public static Data.Invoice? GetInvoice()
        {
            var jsonData = GetJson();

            if (jsonData == null)
            {
                throw new NotImplementedException();
            }

            return JsonConvert.DeserializeObject<Data.Invoice>(jsonData);
            //LOG


        }
    }
}
