using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GroceryList.BusinessDataLogic
{
    class GroceryListService
    {

        static List<string> groceryList = new List<string>();
        public GroceryListService()
        {
            CreateDummyGroceryList();
        }

        public void CreateDummyGroceryList()

            public bool AddItem(string itemToAdd)
        {
            if (!groceryList.Contains(itemToAdd))
            {
                groceryList.Add(itemToAdd);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveItem(string itemToRemove)
        {
            if (groceryList.Contains(itemToRemove))
            {
                groceryList.Remove(itemToRemove);
                return true;
            }
            else
            {
                return false;
            }
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

