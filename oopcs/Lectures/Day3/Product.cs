using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures.Day3
{
    public class Product
    {
        private string _id;
        private string _name;
        private double _price;

        public Product(string id, string name, double price)
        {
            _id = id;
            _name = name;
            _price = price;
        }

        public double Price
        {
            get { return _price; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Id
        {
            get { return _id; }
        }

        public override string ToString()
        {
            return $"Product[{Id}, {Name}, {Price}]";
        }
    }
}
