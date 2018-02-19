using System;

namespace Lectures.Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("Tan Ah Kow");
            Product a = new Product("P1001", "Table", 150);
            Product b = new Product("P1002", "Chair", 50);
            
            c.Buy(a);
            c.Buy(b);

            Console.WriteLine(c);
            Console.WriteLine(c.CostOfPurchase());
        }
    }
}
