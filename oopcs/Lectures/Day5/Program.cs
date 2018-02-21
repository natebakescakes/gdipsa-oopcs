using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures.Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            //A x = new A(8);
            //B y = new B(9);
            //x.P();
            //y.P();
            //x.Q();
            //y.Q();

            int[] numbers = new int[] { 5, 2, 19, 8 };

            Customer[] customers = new Customer[]
            {
                new Customer("Tan Ah Kow", 10000),
                new Customer("Lim Ah Lian", 4000),
                new Customer("Goh Ah Seng", 5000)
            };

            Array.Sort(numbers);
            Array.Sort(customers);

            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine(customers[i]);
            }
        }
    }
}
