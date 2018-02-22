using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshops.AdditionalExercise
{
    public class Customer
    {
        private string name;
        private Dictionary<Product, int> basket;
        private double totalSpent;

        public Customer(string name)
        {
            this.name = name;
            this.basket = new Dictionary<Product, int>();
            this.totalSpent = 0;
        }

        public string Name { get { return name; } }
        public Dictionary<Product, int> Basket { get { return basket; } }
        public double TotalSpent
        {
            get { return totalSpent;  }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Checkout amount cannot be negative.");

                totalSpent = value;
            }
        }
        /// <summary>
        ///     Finds the total cost price of the basket of products the Customer will be checking out.
        /// </summary>
        public double BasketCost
        {
            get
            {
                double total = 0;

                foreach (var item in basket)
                {
                    total += (item.Key.Price * item.Value);
                }

                return total;
            }
        }

        public void AddToBasket(Supermarket supermarket, Product product, int quantity)
        {
            if (supermarket.CheckInventoryLevel(product) <= 0)
                throw new InvalidOperationException(
                    "Unable to add product to basket as there is insufficient inventory"
                    );

            basket.Add(product, quantity);
        }

        public void ResetBasket()
        {
            basket = new Dictionary<Product, int>();
        }
    }
}
