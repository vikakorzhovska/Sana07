using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana07
{
    public class PriceException : Exception
    {
        public decimal Price { get; set; }
        public PriceException(decimal price, string message) : base(message)
        {
            Price = price; 
        }
    }
}
