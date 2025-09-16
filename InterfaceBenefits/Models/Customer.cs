namespace InterfaceBenefits.Models;


/// <summary>
/// Receives financial aid from vendors.
/// </summary>
public class Customer : IDuplicatableItem, ICensorable
{
    public required string SocialSecurityNumber { get; set; }
    public required bool IsHomeless { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public void CensorData()
    {
        bool hasBadCharacterInFirstName = false;
        bool hasBadCharacterInLastName = false;
        const char BadCharacterLowercase = 't';
        const char BadCharacterUppercase = 'T';

        foreach (char c in FirstName)
        {
            if (c == BadCharacterLowercase || c == BadCharacterUppercase)
            {
                hasBadCharacterInFirstName = true;
                break;
            }
        }

        if (hasBadCharacterInFirstName)
            FirstName = "CENSORED";

        foreach (char c in LastName)
        {
            if (c == BadCharacterLowercase || c == BadCharacterUppercase)
            {
                hasBadCharacterInLastName = true;
                break;
            }
        }

        if (hasBadCharacterInLastName)
            LastName = "CENSORED";
    }

    public string GetDisplaybaleNonUniqueData()
    {
        return $"{FirstName} {LastName}";
    }

    public object GetUniqueId()
    {
        return SocialSecurityNumber;
    }
}