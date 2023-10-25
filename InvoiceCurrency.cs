using WinForms.Invoice.Generator.Structure;

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
            SingletonData.Instance.InvoiceData!.Currency = cmbCurrency.SelectedItem?.ToString();
        }
    }
}
