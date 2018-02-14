using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures.Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product a = new Product("Table", "P10001", 20);
            Product b = new Product("Chair", "P10002");
            Customer c = new Customer();

            Console.WriteLine(a);
            a.Restock(12);
            a.DoSomething();
            Console.WriteLine(a);
        }
    }
}
