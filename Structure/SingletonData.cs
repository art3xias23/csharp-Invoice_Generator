using WinForms.Invoice.Generator.Data;
using WinForms.Invoice.Generator.Logic;

namespace WinForms.Invoice.Generator.Structure
{
    public class SingletonData
    {
        public TransitionalData TransitionalData;
        public Data.Invoice? InvoiceData;
        private SingletonData(TransitionalData transitionalData)
        {
            TransitionalData = transitionalData;
            InvoiceData = JsonData.GetInvoice();
        }

        private static SingletonData? instance = null;

        public static SingletonData? Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonData(new TransitionalData());
                }
                return instance;
            }
        }
    }
}
