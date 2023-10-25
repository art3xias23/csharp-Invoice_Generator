namespace WinForms.Invoice.Generator
{
    public partial class InvoiceCurrency :  ISaveUserControl
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
