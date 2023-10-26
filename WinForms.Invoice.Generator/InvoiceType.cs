using System.Security.Cryptography.X509Certificates;
using WinForms.Invoice.Generator.Structure;

namespace WinForms.Invoice.Generator
{
    public partial class InvoiceType :UserControl, ISave
    {

        public InvoiceType()
        {
            InitializeComponent();
            comboBox1.Items.Add(Enums.DocumentType.Invoice);
            comboBox1.Items.Add(Enums.DocumentType.Quote);
        }

        public void Save()
        {
            SingletonData.Instance.InvoiceData.DocumentType = (Enums.DocumentType)comboBox1.SelectedItem;
        }

        private void InvoiceType_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
