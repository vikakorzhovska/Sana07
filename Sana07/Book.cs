using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana07
{
    public class Book : Product
    {
        public string Author { get; set; }
        public string Genre { get; set; }
        public override string Display()
        {
            return $"{Name} {Author} {Genre} {Price} {Count}";
        }
        public Book(string name, decimal price, int count, string author, string genre) : base(name, price, count)
        {
            Author = author ;
            Genre = genre ;
        }
    }
}
