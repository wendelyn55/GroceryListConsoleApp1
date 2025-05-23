using System.Collections.Generic;

namespace GroceryListDataLogic
{
    public class DataLogic
    {
        public static List<string> groceryList = new List<string>();

        public DataLogic()
        {
            CreateDummyGroceryList();
        }
        public static void CreateDummyGroceryList()
        {
            groceryList.Add("Milk");
            groceryList.Add("Bread");
            groceryList.Add("Eggs");
            groceryList.Add("Banana");
            groceryList.Add("Tomatoes");
            groceryList.Add("Chicken Breast");
            groceryList.Add("Rice");
            groceryList.Add("Butter");
            groceryList.Add("Spinach");
            groceryList.Add("Tuna");
        }

        // Creation and adding into the list of grocery items
        public static string CreateGroceryItem(string name)
        {
            return name.Trim();
        }

        public static bool AddItem(string itemToAdd)
        {
            if (!IsInList(itemToAdd))
            {
                groceryList.Add(CreateGroceryItem(itemToAdd));
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool RemoveItem(string itemToRemove)
        {
            if (IsInList(itemToRemove))
            {
                groceryList.Remove(itemToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }

        // Validation and simple attribute retrieval
        public static bool IsInList(string itemInput)
        {
            foreach (string groceryItem in groceryList)
            {
                if (GetItemName(groceryItem).ToLower() == itemInput.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public static string GetItemName(string itemToPrint)
        {
            return itemToPrint;
        }

        public static List<string> GetGroceryList()
        {
            return new List<string>(groceryList);
        }
    }
}
