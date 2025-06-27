using GroceryListDataLogic;

namespace GroceryListBusinessLogic
{
    public class GroceryListService
    {
        private readonly IGroceryDataLogic dataLogic;

        public GroceryListService()
        {
            dataLogic = new InMemoryDataLogic();
        }

        public List<string> GetItems()
        {
            return dataLogic.GetGroceryList();
        }

        public bool AddItem(string item)
        {
            return dataLogic.AddItem(item);
        }

        public bool RemoveItem(string item)
        {
            return dataLogic.RemoveItem(item);
        }

        public void ClearList()
        {
            dataLogic.ClearList();
        }
    }
}

