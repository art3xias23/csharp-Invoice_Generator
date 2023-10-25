namespace WinForms.Invoice.Generator
{
    public partial class InvoiceType : UserControl
    {
        private TransitionalData _transitionalData;

        public InvoiceType(TransitionalData transitionalData)
        {
            _transitionalData = transitionalData;
            InitializeComponent();
            comboBox1.Items.Add("Current Month");
            comboBox1.Items.Add("Next Month");
        }
    }
}
