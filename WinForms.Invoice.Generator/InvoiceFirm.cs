using WinForms.Invoice.Generator.Data;
using WinForms.Invoice.Generator.Structure;

namespace WinForms.Invoice.Generator
{
    public partial class InvoiceFirm : UserControl, ISave
    {
        private Enums.FirmTypeEnum _firmType;
        public InvoiceFirm(Enums.FirmTypeEnum firmType)
        {
            InitializeComponent();

            _firmType = firmType;

            lblTitle.Text = firmType == Enums.FirmTypeEnum.Origin ? "Origin Firm Details" : "Destination Firm Details";
        }

        public void Save()
        {
            var instance = SingletonData.Instance.InvoiceData!;
            SaveFirmDetails(_firmType == Enums.FirmTypeEnum.Origin ? instance.OriginFirm : instance.TargetFirm);
        }

        private void SaveFirmDetails(Firm? firm)
        {
            if (firm == null) return;
            firm.Name = txtFirmName.Text;
            if (firm.Address != null)
            {
                firm.Address.AddressLine1 = txtAddress1.Text;
                firm.Address.AddressLine2 = txtAddressLine2.Text;
                firm.Address.City = txtCity.Text;
                firm.Address.Country = txtCountry.Text;
                firm.Address.Postcode = txtPostcode.Text;
            }

            firm.EmailAddress = txtEmail.Text;
            firm.PhoneNumber = txtPhone.Text;
        }

        private void InvoiceFirm_Load(object sender, EventArgs e)
        {
            var instance = SingletonData.Instance.InvoiceData!;
            LoadFirmDetails(_firmType == Enums.FirmTypeEnum.Origin ? instance.OriginFirm : instance.TargetFirm);
        }

        private void LoadFirmDetails(Firm? firm)
        {
            txtFirmName.Text = firm?.Name;
            txtAddress1.Text = firm?.Address?.AddressLine1;
            txtAddressLine2.Text = firm?.Address?.AddressLine2;
            txtCity.Text = firm?.Address?.City;
            txtCountry.Text = firm?.Address?.Country;
            txtPostcode.Text = firm?.Address?.Postcode;
            txtEmail.Text = firm?.EmailAddress;
            txtPhone.Text = firm?.PhoneNumber;
        }
    }
}
