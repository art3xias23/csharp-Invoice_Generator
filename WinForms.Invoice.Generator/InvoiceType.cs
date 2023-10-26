using System.Security.Cryptography.X509Certificates;
using WinForms.Invoice.Generator.Structure;

namespace WinForms.Invoice.Generator
{
    public partial class InvoiceType :UserControl, ISave
    {
        private int _id;

        public InvoiceType()
        {
            InitializeComponent();
            comboBox1.Items.Add(Enums.DocumentType.Invoice);
            comboBox1.Items.Add(Enums.DocumentType.Quote);
        }

        public void Save()
        {
            SingletonData.Instance.InvoiceData.DocumentType = (Enums.DocumentType)comboBox1.SelectedItem;
            if ((Enums.DocumentType)comboBox1.SelectedItem == Enums.DocumentType.Invoice)
            {
                SingletonData.Instance.InvoiceData.InvoiceId = _id;
            }
            else if((Enums.DocumentType)comboBox1.SelectedItem == Enums.DocumentType.Quote)
            {

                SingletonData.Instance.InvoiceData.QuoteId = _id;
            }
        }

        private void InvoiceType_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = SingletonData.Instance.InvoiceData;
            if ((Enums.DocumentType)comboBox1.SelectedItem == Enums.DocumentType.Invoice)
            {
                _id = data.InvoiceId+1;
                lblDocType.Visible = true;
                txtDocTypeId.Visible = true;
                lblDocType.Text = "InvoiceId:";
                txtDocTypeId.Text = _id.ToString("D10");
            }
            else if((Enums.DocumentType)comboBox1.SelectedItem == Enums.DocumentType.Quote)
            {
                _id = data.QuoteId+1;
                lblDocType.Visible = true;
                txtDocTypeId.Visible = true;
                lblDocType.Text = "QuoteId:";
                txtDocTypeId.Text = _id.ToString("D10");
            }
        }
    }
}
