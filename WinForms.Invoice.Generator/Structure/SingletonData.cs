using WinForms.Invoice.Generator.Logic;

namespace WinForms.Invoice.Generator.Structure
{
    public class SingletonData
    {
        public Data.Invoice? InvoiceData;
        private SingletonData()
        {
            InvoiceData = JsonData.GetInvoice();
        }

        private static SingletonData? instance = null;

        public static SingletonData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonData();
                }
                return instance;
            }
        }
    }
}
