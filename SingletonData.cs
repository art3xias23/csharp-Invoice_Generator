using System.Net.NetworkInformation;

namespace WinForms.Invoice.Generator
{
    public class SingletonData
    {
        public TransitionalData transitionalData;
        private SingletonData(TransitionalData transitionalData)
        {
            this.transitionalData = transitionalData;
        }

        private static SingletonData instance = null;

        public static SingletonData Instance
        {
            get {
                if (instance == null) {
                    instance = new SingletonData(new TransitionalData());
                }
                return instance;
            }
        }
    }
}
