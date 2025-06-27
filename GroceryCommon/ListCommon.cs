using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryList.BusinessDataLogic
{
    public class GroceryListCommon
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public GroceryListCommon(string name, int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }
    }
}

