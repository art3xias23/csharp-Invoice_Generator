using Newtonsoft.Json;
using WinForms.Invoice.Generator.Data;
using WinForms.Invoice.Generator.Structure;

namespace WinForms.Invoice.Generator.Logic
{
    public  class JsonData
    {
        private static string? GetJson()
        {
            var json = File.ReadAllText(@"..\..\..\Data.json");

            return json;
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

        public static void SaveData()
        {
            var data = SingletonData.Instance.InvoiceData;
            data.WorkingDays = new List<WorkingDay>();
            File.WriteAllText(@"..\..\..\Data.json",JsonConvert.SerializeObject(data));
        }
    }
}
