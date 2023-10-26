using DocumentFormat.OpenXml.Presentation;

namespace WinForms.Invoice.Generator.Data;

public class Invoice
{
    public List<WorkingDay> WorkingDays { get; set; }
    public decimal HoursPerDay { get; set; }
    public decimal HourlyPayment { get; set; }
    public string? Currency { get; set; }
    public Firm? OriginFirm { get; set; }
    public Firm? TargetFirm { get; set; }
    public BankDetails? OriginBankDetails { get; set; }
    public string? Paragraph1 { get; set; }
    public string? Paragraph2 { get; set; }
    public string? Paragraph3 { get; set; }
    public string? Paragraph4 { get; set; }
    public string? Paragraph5 { get; set; }
    public string? Paragraph6 { get; set; }
    public string? Paragraph7 { get; set; }
}