﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryCommon;

namespace GroceryDataLogic
{
    public class GroceryFileDataLogic
    {
        private List<GroceryItem> groceryList = new List<GroceryItem>();
        private string filepath = "grocerylist.txt";

        public GroceryFileDataLogic()
        {
            ImportFromFile();
        }

        private void ImportFromFile()
        {
            if (!File.Exists(filepath))
                return;

            var lines = File.ReadAllLines(filepath);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    groceryList.Add(new GroceryItem(parts[0], parts[1], parts[2]));
                }
            }
        }

        private void ExportToFile()
        {
            var lines = new string[groceryList.Count];
            for (int i = 0; i < groceryList.Count; i++)
            {
                lines[i] = $"{groceryList[i].ItemName}|{groceryList[i].Quantity}|{groceryList[i].Category}";
            }

            File.WriteAllLines(filepath, lines);
        }

        public List<GroceryItem> GetGroceryItems()
        {
            return groceryList;
        }

        public void AddItem(GroceryItem item)
        {
            groceryList.Add(item);
            ExportToFile();
        }

        public void RemoveItem(string itemName)
        {
            groceryList.RemoveAll(x => x.ItemName.Equals(itemName, StringComparison.OrdinalIgnoreCase));
            ExportToFile();
        }

        public void UpdateItem(GroceryItem updatedItem)
        {
            for (int i = 0; i < groceryList.Count; i++)
            {
                if (groceryList[i].ItemName.Equals(updatedItem.ItemName, StringComparison.OrdinalIgnoreCase))
                {
                    groceryList[i].Quantity = updatedItem.Quantity;
                    groceryList[i].Category = updatedItem.Category;
                }
            }
            ExportToFile();
        }

        public int FindItemIndex(GroceryItem item)
        {
            for (int i = 0; i < groceryList.Count; i++)
            {
                if (groceryList[i].ItemName.Equals(item.ItemName, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}