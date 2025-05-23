using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryListDataLogic
{
    public interface IURGroceryDataLogic
    {
        List<GroceryItem> GetItems();
       public void CreateItem(GroceryItem item);
       public void RemoveItem(GroceryItem item);
       public void UpdateItem(GroceryItem item);
       public void ClearItem(GroceryItem item);
    }
}