namespace WinForms.Invoice.Generator
{
    public partial class InvoiceFirm : UserControl
    {
        private Enums.FirmTypeEnum _firmType;
        public InvoiceFirm(Enums.FirmTypeEnum firmType)
        {
            InitializeComponent();

            _firmType = firmType;
        }
    }
}
