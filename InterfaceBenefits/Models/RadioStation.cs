namespace InterfaceBenefits.Models;

/// <summary>
/// Radio Station, pretend that two frequencies cannot exist in the same state
/// </summary>
public class RadioStation
{
    public required float Frequency { get; set; }
    public required string Name { get; set; }
    public required string State { get; set; }
}