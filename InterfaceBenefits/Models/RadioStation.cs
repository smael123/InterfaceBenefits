namespace InterfaceBenefits.Models;

/// <summary>
/// Radio Station, pretend that two frequencies cannot exist in the same state
/// </summary>
public class RadioStation : IDuplicatableItem
{
    public required float Frequency { get; set; }
    public required string Name { get; set; }
    public required string State { get; set; }

    public string GetDisplaybaleNonUniqueData()
    {
        return Name;
    }

    public object GetUniqueId()
    {
        return (Frequency, State);
    }
}