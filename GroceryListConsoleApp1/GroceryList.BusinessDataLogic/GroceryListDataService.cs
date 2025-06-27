using GroceryListDataLogic;
using System.Collections.Generic;

namespace GroceryList.Services
{
    public class GroceryDataService
    {
        private IGroceryDataLogic groceryDataLogic;

        public GroceryDataService()
        {
            // groceryDataLogic = new JsonFileDataLogic();
            // groceryDataLogic = new TextFileDataLogic();
            groceryDataLogic = new InMemoryDataLogic();
        }

        public List<string> GetAllItems()
        {
            return groceryDataLogic.GetGroceryList();
        }

        public bool AddItem(string item)
        {
            return groceryDataLogic.AddItem(item);
        }

        public bool RemoveItem(string item)
        {
            return groceryDataLogic.RemoveItem(item);
        }
    }
}