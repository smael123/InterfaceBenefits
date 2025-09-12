using InterfaceBenefits.Models;

namespace InterfaceBenefits.Utils;

public static class VendorDuplicateFinder
{
    /// <summary>
    /// Displays a report of duplicated vendors.
    /// </summary>
    /// <param name="vendors"></param>
    public static void ShowDuplicateVendors(IEnumerable<Vendor> vendors)
    {
        Dictionary<string, HashSet<string>> duplicateDictionary = new();

        foreach (Vendor vendor in vendors)
        {
            if (!duplicateDictionary.TryGetValue(vendor.TaxId, out HashSet<string>? duplicatedData))
            {
                duplicateDictionary.Add(vendor.TaxId, [vendor.BusinessName]);
            }
            else
            {
                duplicatedData.Add(vendor.BusinessName);
            }
            
        }

        foreach (string key in duplicateDictionary.Keys)
        {
            HashSet<string> duplicateArray = duplicateDictionary[key];

            Console.WriteLine($"Vendor with id: {key} is duplicated. Duplicated Data {string.Join(" | ", duplicateArray)}");
        }
    }
}