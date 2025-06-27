using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;


namespace GroceryListDataLogic
{
    public class JsonFileDataLogic : IGroceryDataLogic
    {
        private readonly string filePath = "groceryList.json";

        public List<string> GetGroceryList()
        {
            if (!File.Exists(filePath))
                File.WriteAllText(filePath, "[]");

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<string>>(json) ?? new List<string>();
        }

        public bool AddItem(string itemToAdd)
        {
            var items = GetGroceryList();
            if (!items.Contains(itemToAdd, System.StringComparer.OrdinalIgnoreCase))
            {
                items.Add(itemToAdd.Trim());
                SaveList(items);
                return true;
            }
            return false;
        }

        public bool RemoveItem(string itemToRemove)
        {
            var items = GetGroceryList();
            var updated = items.Where(i => !i.Equals(itemToRemove, System.StringComparison.OrdinalIgnoreCase)).ToList();
            if (updated.Count < items.Count)
            {
                SaveList(updated);
                return true;
            }
            return false;
        }

        private void SaveList(List<string> items)
        {
            var json = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public void ClearList()
        {
            SaveList(new List<string>());
        }
    }
}
