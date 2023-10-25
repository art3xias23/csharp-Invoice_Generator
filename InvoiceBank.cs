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
                instance.OriginBankDetails.Bank = txtBankName.Text;
                instance.OriginBankDetails.BankAccount = txtBankAccount.Text;
                instance.OriginBankDetails.Beneficiary = txtBeneficiary.Text;
                instance.OriginBankDetails.SortCode = txtSortCode.Text;
                instance.OriginBankDetails.Address.AddressLine1 = txtSortCode.Text;
        }
    }
}
