namespace InterfaceBenefits.Models;

/// <summary>
/// Distributes financial aid to customers
/// </summary>
public class Vendor : IDuplicatableItem
{
    public required string TaxId { get; set; }
    public required string BusinessName { get; set; }
    public required bool IsCompliance { get; set; }

    public string GetDisplaybaleNonUniqueData()
    {
        return BusinessName;
    }

    public object GetUniqueId()
    {
        return TaxId;
    }
}