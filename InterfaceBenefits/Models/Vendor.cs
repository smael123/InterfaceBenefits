namespace InterfaceBenefits.Models;

/// <summary>
/// Distributes financial aid to customers
/// </summary>
public class Vendor : IDuplicatableItem, ICensorable
{
    public required string TaxId { get; set; }
    public required string BusinessName { get; set; }
    public required bool IsCompliance { get; set; }

    public void CensorData()
    {
        bool hasJay = false;

        foreach (char c in BusinessName) { 
            if (c == 'j' || c == 'J')
            {
                hasJay = true;
                break;
            }
        }

        if (hasJay)
            BusinessName = "CENSORED";
    }

    public string GetDisplaybaleNonUniqueData()
    {
        return BusinessName;
    }

    public object GetUniqueId()
    {
        return TaxId;
    }
}