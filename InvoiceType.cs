namespace WinForms.Invoice.Generator
{
    public partial class InvoiceType : UserControl
    {

        public InvoiceType()
        {
            InitializeComponent();
            comboBox1.Items.Add("Current Month");
            comboBox1.Items.Add("Next Month");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SingletonData.Instance.transitionalData.InvoiceMonth = (string)comboBox1.SelectedItem;
        }
    }
}
