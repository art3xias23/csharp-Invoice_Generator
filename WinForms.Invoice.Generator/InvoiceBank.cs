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
                {
                    instance.OriginBankDetails.Address.AddressLine1 = txtAddress1.Text;
                    instance.OriginBankDetails.Address.AddressLine2 = txtAddressLine2.Text;
                    instance.OriginBankDetails.Address.City = txtCity.Text;
                    instance.OriginBankDetails.Address.Postcode = txtPostcode.Text;
                    instance.OriginBankDetails.Address.Country = txtCountry.Text;
                }
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
            txtAddress1.Text = instance.OriginBankDetails?.Address?.AddressLine1;
            txtAddressLine2.Text = instance.OriginBankDetails?.Address?.AddressLine2;
            txtCity.Text = instance.OriginBankDetails?.Address?.City;
            txtPostcode.Text = instance.OriginBankDetails?.Address?.Postcode;
            txtCountry.Text = instance.OriginBankDetails?.Address?.Country;

        }

        private void InvoiceBank_Load(object sender, EventArgs e)
        {
            LoadInformation();
        }
    }
}
