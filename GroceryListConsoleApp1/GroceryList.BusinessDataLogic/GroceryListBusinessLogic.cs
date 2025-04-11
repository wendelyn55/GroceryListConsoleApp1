using GroceryList.BusinessDataLogic;
using GroceryListDataLogic;

namespace GroceryList.BusinessLogic
{
    public class BusinessLogic
    {
        public static string SearchGroceryItem(string itemToFind)
        {
            foreach (string item in DataLogic.GetGroceryList())
            {
                if (GetGroceryItemName(item).Equals(itemToFind, StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }
            }
            return null; 
        }

        public static string CreateGroceryItem(string itemName)
        {
            return itemName.Trim();
        }
        public static bool AddGroceryItem(string item)
        {
            if (!DataLogic.IsInList(item) && !string.IsNullOrWhiteSpace(item))
            {
                return DataLogic.AddItem(CreateGroceryItem(item));
            }
            return false; 
        }
        public static bool RemoveGroceryItem(string item)
        {
            return DataLogic.RemoveItem(item);
        }
        public static List<string> GetGroceryList()
        {
            return DataLogic.GetGroceryList();
        }
        public static string GetGroceryItemName(string groceryItem)
        {
            return DataLogic.GetItemName(groceryItem); 
        }
        public static void CreateDummyGroceryList()
        {
            DataLogic.CreateDummyGroceryList(); 
        }
    }
}