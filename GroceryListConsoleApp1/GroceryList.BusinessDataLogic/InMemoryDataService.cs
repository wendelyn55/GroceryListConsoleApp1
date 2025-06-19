using System.Collections.Generic;

namespace GroceryListDataLogic
{
    public class InMemoryDataLogic : IGroceryDataLogic
    {
        private static List<string> groceryList = new List<string>();

        public InMemoryDataLogic()
        {
            if (groceryList.Count == 0)
                CreateDummyGroceryList();
        }

        private static void CreateDummyGroceryList()
        {
            groceryList.AddRange(new List<string>
            {
                "Milk", "Bread", "Eggs", "Banana", "Tomatoes",
                "Chicken Breast", "Rice", "Butter", "Spinach", "Tuna"
            });
        }

        public bool AddItem(string itemToAdd)
        {
            if (!groceryList.Contains(itemToAdd, System.StringComparer.OrdinalIgnoreCase))
            {
                groceryList.Add(itemToAdd.Trim());
                return true;
            }
            return false;
        }

        public bool RemoveItem(string itemToRemove)
        {
            return groceryList.RemoveAll(i => i.Equals(itemToRemove, System.StringComparison.OrdinalIgnoreCase)) > 0;
        }

        public List<string> GetGroceryList()
        {
            return new List<string>(groceryList);
        }
    }
}
