using System;
using System.Collections.Generic;

namespace GroceryList.BusinessDataLogic
{
    public class GroceryListService
    {
        static List<string> groceryList = new List<string>();

        public GroceryListService()
        {
            CreateDummyGroceryList();
        }

        public void CreateDummyGroceryList()
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

        public bool AddItem(string itemToAdd)
        {
            if (!groceryList.Contains(itemToAdd))
            {
                groceryList.Add(itemToAdd);
                return true;
            }
            return false;
        }

        public bool RemoveItem(string itemToRemove)
        {
            if (groceryList.Contains(itemToRemove))
            {
                groceryList.Remove(itemToRemove);
                return true;
            }
            return false;
        }

        public void ClearList()
        {
            groceryList.Clear();
        }

        public List<string> GetItems()
        {
            return groceryList;
        }
    }
}
