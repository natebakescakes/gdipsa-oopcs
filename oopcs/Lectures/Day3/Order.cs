using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures.Day3
{
    public class Order
    {
        private Product[] _items;
        private int _count;

        public Order(int maxProducts)
        {
            _count = 0;
            _items = new Product[maxProducts];
        }

        public void Add(Product p)
        {
            _items[_count] = p;
            _count++;
        }

        public double TotalPrice()
        {
            double totalPrice = 0;

            for (int i = 0; i < _count; i++)
            {
                totalPrice += _items[i].Price;
            }

            return totalPrice;
        }

        public override string ToString()
        {
            string printString = "";

            for (int i = 0; i < _count; i++)
            {
                printString += _items[i];

                if (i != _count - 1) // if not the last item
                    printString += "\n";
            }

            return printString;
        }
    }
}
