﻿namespace Lectures.Day3
{
    public class Customer
    {
        private string _name;
        private Order order;
        public static int numberOfCustomers = 0;

        public Customer(string name)
        {
            _name = name;
            order = new Order(8);
            numberOfCustomers++;
        }

        public void Buy(Product p)
        {
            order.Add(p);
        }

        public double CostOfPurchase()
        {
            return order.TotalPrice();
        }

        public override string ToString()
        {
            return order.ToString();
        }
    }
}
