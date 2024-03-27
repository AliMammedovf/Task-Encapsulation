using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation__class
{
    internal class Product
    {
        private double _price;
        private int _count;
        public byte No;
        public string Name;




        public Product()
        {

        }

        public Product(double price, int count, byte no, string name)
        {
            _price = price;
            _count = count;
            No = no;
            Name = name;
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
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
                {
                    _count = value;
                }
            }
        }
    }
}
