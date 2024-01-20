using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana07
{
    public class CountException : Exception
    {
        public int Count { get; set; }
        public CountException(int count, string message) : base(message)
        {
            Count = count;
        }
    }
}
