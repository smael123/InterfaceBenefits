namespace InterfaceBenefits.Models;

/// <summary>
/// Distributes financial aid to customers
/// </summary>
public class Vendor
{
    public required string TaxId { get; set; }
    public required string BusinessName { get; set; }
    public required bool IsCompliance { get; set; }
}