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
            SingletonData.Instance.InvoiceData.HourlyPayment = nudHoursPerDay.Value;
            SingletonData.Instance.InvoiceData.HoursPerDay = SingletonData.Instance.InvoiceData.HoursPerDay;

        }

        private void InvoiceCurrency_Load(object sender, EventArgs e)
        {
            cmbCurrency.SelectedItem = SingletonData.Instance.InvoiceData!.Currency;
            nudPaymentPerHour.Value = SingletonData.Instance.InvoiceData.HourlyPayment;
            nudHoursPerDay.Value = SingletonData.Instance.InvoiceData.HoursPerDay;
        }
    }
}
