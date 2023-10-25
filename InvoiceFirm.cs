namespace WinForms.Invoice.Generator
{
    public partial class InvoiceFirm :  ISaveUserControl
    {
        private Enums.FirmTypeEnum _firmType;
        public InvoiceFirm(Enums.FirmTypeEnum firmType)
        {
            InitializeComponent();

            _firmType = firmType;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
