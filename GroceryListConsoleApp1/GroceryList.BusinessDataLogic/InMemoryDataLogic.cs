using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryCommon;


namespace GroceryDataLogic
{
    public class InMemoryGroceryDataLogic : IURGroceryDataLogic
    {
        private static List<GroceryItem> groceryList = new List<GroceryItem>();

        public InMemoryGroceryDataLogic()
        {
            CreateDummyGroceryItems();
        }

        private static void CreateDummyGroceryItems()
        {
            groceryList.Add(new GroceryItem("Milk", "2 Liters", "Dairy"));
            groceryList.Add(new GroceryItem("Bread", "1 Loaf", "Bakery"));
            groceryList.Add(new GroceryItem("Eggs", "1 Dozen", "Dairy"));
            groceryList.Add(new GroceryItem("Bananas", "6 pcs", "Fruits"));
            groceryList.Add(new GroceryItem("Tomatoes", "1 kg", "Vegetables"));
            groceryList.Add(new GroceryItem("Chicken Breast", "500g", "Meat"));
            groceryList.Add(new GroceryItem("Rice", "5 kg", "Grains"));
            groceryList.Add(new GroceryItem("Butter", "250g", "Dairy"));
            groceryList.Add(new GroceryItem("Spinach", "1 bunch", "Vegetables"));
            groceryList.Add(new GroceryItem("Tuna", "2 cans", "Canned Goods"));
        }

        public void CreateItem(GroceryItem item)
        {
            groceryList.Add(item);
        }

        public List<GroceryItem> GetItems()
        {
            return groceryList;
        }

        public void RemoveItem(GroceryItem item)
        {
            groceryList.RemoveAll(x => x.ItemName.Equals(item.ItemName, StringComparison.OrdinalIgnoreCase));
        }

        public void UpdateItem(GroceryItem item)
        {
            for (int i = 0; i < groceryList.Count; i++)
            {
                if (groceryList[i].ItemName.Equals(item.ItemName, StringComparison.OrdinalIgnoreCase))
                {
                    groceryList[i].Quantity = item.Quantity;
                    groceryList[i].Category = item.Category;
                    break;
                }
            }
        }
    }
}