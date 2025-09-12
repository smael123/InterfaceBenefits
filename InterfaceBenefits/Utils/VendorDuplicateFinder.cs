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
        Dictionary<string, List<string>> duplicateDictionary = [];
        HashSet<string> idsWithDuplicatedData = [];

        foreach (Vendor vendor in vendors)
        {
            if (!duplicateDictionary.TryGetValue(vendor.TaxId, out List<string>? duplicatedData))
            {
                duplicateDictionary.Add(vendor.TaxId, [vendor.BusinessName]);
            }
            else
            {
                duplicatedData.Add(vendor.BusinessName);
                idsWithDuplicatedData.Add(vendor.TaxId);
            }
        }

        Console.WriteLine("Duplicated Vendors");
        Console.WriteLine();
        
        foreach (string key in idsWithDuplicatedData)
        {
            List<string> duplicateArray = duplicateDictionary[key];
            
            if (duplicateArray.Count > 1)
                Console.WriteLine($"Id: {key} is duplicated. Duplicated Data: {string.Join(" | ", duplicateArray)}");
        }
    }
}