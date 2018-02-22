using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshops.AdditionalExercise
{
    public class Supermarket
    {
        private string name;
        private Dictionary<Product, int> inventory;
        // Key = Transaction Id, Value = Customer Name, Amount spent
        private Dictionary<int, Tuple<Customer, double>> transactions;
        private List<Customer> membership;
        private double membershipDiscount;

        public Supermarket(string name, double membershipDiscount)
        {
            this.name = name;
            this.inventory = new Dictionary<Product, int>();
            this.transactions = new Dictionary<int, Tuple<Customer, double>>();
            this.membership = new List<Customer>();
            this.membershipDiscount = membershipDiscount;
        }

        public Supermarket(string name) : this(name, 0) { }

        public string Name { get { return name; } }
        public double MembershipDiscount { get { return membershipDiscount; } }
        public double TotalRevenue
        {
            get
            {
                return transactions.Sum(transaction => transaction.Value.Item2);
            }
        }

        public Product FindProduct(string productName)
        {
            foreach (var item in inventory)
            {
                if (item.Key.Name == productName)
                    return item.Key;
            }

            throw new ArgumentException("Unable to find product");
        }

        public void AddProduct(Product product, int quantity)
        {
            inventory.Add(product, quantity);
        }

        public void CheckOutCustomer(Customer customer)
        {
            if (customer.Basket.Count == 0)
                throw new ArgumentException("Customer has no items to check out!");

            // Add Transaction
            AddCheckOutTransaction(customer);

            // Increment customer's total expenditure
            IncreaseCustomerExpenditure(customer, customer.BasketCost);

            // Remove items from inventory
            foreach (var item in customer.Basket)
            {
                inventory[item.Key] -= item.Value;
            }

            // Remove all customer items
            customer.ResetBasket();
        }

        private void AddCheckOutTransaction(Customer customer)
        {
            int transactionId;

            if (transactions.Count == 0)
                transactionId = 1;
            else
                transactionId = transactions.Keys.Max() + 1;

            if (!membership.Contains(customer))
                transactions.Add(transactionId, new Tuple<Customer, double>(customer, customer.BasketCost));
            else
                transactions.Add(transactionId, new Tuple<Customer, double>(customer, (customer.BasketCost * (1 - membershipDiscount))));
        }

        private void IncreaseCustomerExpenditure(Customer customer, double amount)
        {
            if (membership.Contains(customer))
                customer.TotalSpent += (amount * (1 - membershipDiscount));
            else
                customer.TotalSpent += amount;
        }

        public int CheckInventoryLevel(Product product)
        {
            return inventory[product];
        }

        public void AddMember(Customer customer)
        {
            membership.Add(customer);
        }

        public Customer FindMember(string customerName)
        {
            foreach (var customer in membership)
            {
                if (customer.Name == customerName)
                    return customer;
            }

            throw new ArgumentException("Unable to find member");
        }
    }
}
