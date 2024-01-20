using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana07
{
    public class Table : Product
    {
        public string Material { get; set; }
        public string Size { get; set; }
        public override string Display()
        {
            return $"{Name} {Material} {Size} {Price} {Count}";
        }
        public Table(string name, decimal price, int count, string material, string size) : base(name, price, count)
        {
            Material = material ;
            Size = size ;
        }
    }
}
