using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana07
{
    public abstract class Product
    {
        public string Name { get; set; }
        protected decimal _price;
        protected int _count;
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                    _price = value;
                else
                    throw new PriceException(value, "Ціна не може бути від'ємною");
            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value > 0)
                    _count = value;
                else
                    throw new CountException(value, "Кількість не може бути від'ємною");
            }
        }
        public abstract string Display();
        public Product(string name, decimal price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
    }
}
