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
            if (_firmType == Enums.FirmTypeEnum.Origin)
            {
                SaveFirmDetails(instance.OriginFirm);
            }
            else
            {
                SaveFirmDetails(instance.TargetFirm);
            }
        }

        private void SaveFirmDetails(Firm firm)
        {
            firm.Name = txtFirmName.Text;
            firm.Address.AddressLine1 = txtAddress1.Text;
            firm.Address.AddressLine2 = txtAddressLine2.Text;
            firm.Address.City = txtCity.Text;
            firm.Address.Country = txtCountry.Text;
            firm.Address.Postcode = txtPostcode.Text;
            firm.EmailAddress = txtEmail.Text;
            firm.PhoneNumber = txtPhone.Text;
        }
    }
}
