namespace WinForms.Invoice.Generator
{
    public partial class InvoiceCurrency : UserControl, ISave
    {
        public InvoiceCurrency()
        {
            InitializeComponent();

            cmbCurrency.Items.Add("£");
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
