using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshops.AdditionalExercise
{
    public class Product
    {
        private string name;
        private string id;
        private double price;

        public Product(string name, string id, double price)
        {
            this.name = name;
            this.id = id;
            this.price = price;
        }

        public string Name { get { return name; } }
        public string Id { get { return id; } }
        public double Price { get { return price; } }
    }
}
