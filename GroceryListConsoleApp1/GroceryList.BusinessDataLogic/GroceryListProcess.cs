using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GroceryList.BusinessDataLogic
{
    class GroceryListProcess
    {
        public class GroceryListBusinessLogic
        {
            public static List<string> groceryList = new List<string>();

            public static bool AddItem(string itemToAdd)
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

            public static bool RemoveItem(string itemToRemove)
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

            public static void ClearList()
            {
                groceryList.Clear();
            }

            public static List<string> GetItems()
            {
                return groceryList;
            }
        }
    }
}
