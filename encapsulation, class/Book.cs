using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace encapsulation__class
{
    internal class Book:Product
    {
        public string Genre;

        public Book()
        {

        }

        public Book(double price, int count, byte no, string name, string genre) : base(price, count, no, name)
        {
            Genre = genre;
        }
        public string ShowInfo()
        {
            return $" Name:{Name}\n Price:{Price}\n Count:{Count}\n No:{No}\n Genre:{Genre}";
        }

    }
}
