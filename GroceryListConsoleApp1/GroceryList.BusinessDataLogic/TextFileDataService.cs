using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GroceryListDataLogic
{
    public class TextFileDataLogic : IGroceryDataLogic
    {
        private readonly string filePath = "groceryList.txt";

        public List<string> GetGroceryList()
        {
            if (!File.Exists(filePath))
                File.WriteAllLines(filePath, new List<string>());

            return File.ReadAllLines(filePath).ToList();
        }

        public bool AddItem(string itemToAdd)
        {
            var items = GetGroceryList();
            if (!items.Contains(itemToAdd, System.StringComparer.OrdinalIgnoreCase))
            {
                File.AppendAllText(filePath, itemToAdd + "\n");
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
                File.WriteAllLines(filePath, updated);
                return true;
            }
            return false;
        }
        public void ClearList()
        {
            File.WriteAllText(filePath, string.Empty);
        }
    }
}
