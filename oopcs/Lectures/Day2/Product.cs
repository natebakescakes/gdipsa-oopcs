using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures.Day2
{
    public class Product
    {
        // attributes
        private int _quantity;
        private string _name;
        private string _id;

        // contructor
        // Main constructor
        public Product(string name, string id, int quantity)
        {
            _name = name;
            _id = id;
            Quantity = quantity;
        }

        // Constructor initializer for overloaded constructors
        // uses colon character and 'this' with constructor parameters.
        public Product(string name, string id) : this(name, id, 1) { }
        public Product() : this("", "P0000", 0) { }

        // properties
        public string Name
        {
            get
            {
                return _name;
            }
        }
        
        public string Id
        {
            get
            {
                return _id;
            }
        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value >= 0)
                    _quantity = value;
            }
        }

        // methods
        public void Restock(int quantity)
        {
            this.Quantity += quantity;
        }

        public override string ToString()
        {
            return $"Product: {this.Name}, {this.Id}, {this.Quantity}";
        }

        public void DoSomething()
        {
            Console.WriteLine("Called DoSomething"); // stub (throw new NotImplementedException())
        }
    }
}
