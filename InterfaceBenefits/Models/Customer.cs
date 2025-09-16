namespace InterfaceBenefits.Models;


/// <summary>
/// Receives financial aid from vendors.
/// </summary>
public class Customer : IDuplicatableItem
{
    public required string SocialSecurityNumber { get; set; }
    public required bool IsHomeless { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public string GetDisplaybaleNonUniqueData()
    {
        return $"{FirstName} {LastName}";
    }

    public string GetUniqueId()
    {
        return SocialSecurityNumber;
    }
}