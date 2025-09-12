using InterfaceBenefits.Models;

namespace InterfaceBenefits.Utils;

public static class DuplicateFinder
{
    /// <summary>
    /// Displays a report of duplicated duplicatableItems.
    /// </summary>
    /// <param name="duplicatableItems"></param>
    public static void ShowDuplicateItems(IEnumerable<IDuplicatableItem> duplicatableItems, string pluralItemName)
    {
        Dictionary<string, List<string>> duplicateDictionary = [];
        HashSet<string> idsWithDuplicatedData = [];

        foreach (IDuplicatableItem item in duplicatableItems)
        {
            if (!duplicateDictionary.TryGetValue(item.GetUniqueId(), out List<string>? duplicatedData))
            {
                duplicateDictionary.Add(item.GetUniqueId(), [item.GetDisplaybaleNonUniqueData()]);
            }
            else
            {
                duplicatedData.Add(item.GetDisplaybaleNonUniqueData());
                idsWithDuplicatedData.Add(item.GetUniqueId());
            }
        }

        Console.WriteLine($"Differing {pluralItemName}");
        Console.WriteLine();
        
        foreach (string key in idsWithDuplicatedData)
        {
            List<string> duplicateArray = duplicateDictionary[key];
            
            if (duplicateArray.Count > 1)
                Console.WriteLine($"Id: {key} is duplicated. Duplicated Data: {string.Join(" | ", duplicateArray)}");
        }
    }
}