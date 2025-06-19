using System.Collections.Generic;

namespace GroceryListDataLogic
{
    public interface IGroceryDataLogic
    {
        List<string> GetGroceryList();
        bool AddItem(string itemToAdd);
        bool RemoveItem(string itemToRemove);
    }
}
