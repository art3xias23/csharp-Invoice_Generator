namespace WinForms.Invoice.Generator;

    public class BankDetails
    {
        public string Bank { get; set; }
        public Address Address { get; set; }
        public string Beneficiary { get; set; }
        public string BankAccount { get; set; }
        public string SortCode { get; set; }
    }