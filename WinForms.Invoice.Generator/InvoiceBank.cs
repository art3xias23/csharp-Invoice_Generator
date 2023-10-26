using WinForms.Invoice.Generator.Structure;

namespace WinForms.Invoice.Generator
{
    public partial class InvoiceBank : UserControl, ISave
    {
        public InvoiceBank()
        {
            InitializeComponent();
        }

        public void Save()
        {
            var instance = SingletonData.Instance.InvoiceData!;
            if (instance.OriginBankDetails != null)
            {
                instance.OriginBankDetails.Bank = txtBankName.Text;
                instance.OriginBankDetails.BankAccount = txtBankAccount.Text;
                instance.OriginBankDetails.Beneficiary = txtBeneficiary.Text;
                instance.OriginBankDetails.SortCode = txtSortCode.Text;
                if (instance.OriginBankDetails.Address != null)
                    instance.OriginBankDetails.Address.AddressLine1 = txtSortCode.Text;
            }
        }

        public void LoadInformation()
        {
            var instance = SingletonData.Instance.InvoiceData;
            if (instance == null) return;
            txtBankName.Text = instance.OriginBankDetails?.Bank;
            txtBankAccount.Text = instance.OriginBankDetails?.BankAccount;
            txtBeneficiary.Text = instance.OriginBankDetails?.Beneficiary;
            txtSortCode.Text = instance.OriginBankDetails?.SortCode;
            txtSortCode.Text = instance.OriginBankDetails?.Address?.AddressLine1;
        }

        private void InvoiceBank_Load(object sender, EventArgs e)
        {
            LoadInformation();
        }
    }
}
