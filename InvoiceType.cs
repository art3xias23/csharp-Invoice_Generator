using WinForms.Invoice.Generator.Structure;

namespace WinForms.Invoice.Generator
{
    public partial class InvoiceType : ISaveUserControl
    {

        public InvoiceType()
        {
            InitializeComponent();
            comboBox1.Items.Add("Current Month");
            comboBox1.Items.Add("Next Month");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SingletonData.Instance.TransitionalData.InvoiceMonth = (string)comboBox1.SelectedItem;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
