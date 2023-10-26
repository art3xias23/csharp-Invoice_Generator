using DocumentFormat.OpenXml.Presentation;

namespace WinForms.Invoice.Generator.Data;

public class Invoice
{
    public Enums.DocumentType DocumentType { get; set; }
    public List<WorkingDay> WorkingDays { get; set; }
    public decimal HoursPerDay { get; set; }
    public decimal HourlyPayment { get; set; }
    public string? Currency { get; set; }
    public Firm? OriginFirm { get; set; }
    public Firm? TargetFirm { get; set; }
    public BankDetails? OriginBankDetails { get; set; }
    public string? InvoiceParagraph1 { get; set; }
    public string? InvoiceParagraph2 { get; set; }
    public string? InvoiceParagraph3 { get; set; }
    public string? InvoiceParagraph4 { get; set; }
    public string? InvoiceParagraph5 { get; set; }
    public string? InvoiceParagraph6 { get; set; }
    public string? InvoiceParagraph7 { get; set; }
}