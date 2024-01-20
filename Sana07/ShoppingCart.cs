using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana07
{
    public class ShoppingCart
    {
        private List<Product> items;
        public ShoppingCart() 
        { 
            items = new List<Product>();
        }
        public List<string> ItemsInfo()
        {
            List<string> itemStrings = new List<string>();
            foreach (var item in items)
            {
                itemStrings.Add(item.Display());
            }
            return itemStrings; 
        }
        public decimal TotalPrice()
        {
            decimal sum = 0;
            foreach (var item in items)
            {
                sum += item.Price * item.Count;
            }
            return sum;
        }
    }
}
