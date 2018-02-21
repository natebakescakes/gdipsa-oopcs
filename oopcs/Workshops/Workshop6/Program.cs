using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshops.Workshop6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 6.3
            Customer c = new Customer("Tan Ah Kow", "4 Short Street", 2000);
            Customer d = new Customer("Tan Ah Lian", "81 Berry Road", 1500);
            int n = 65;
            int m = 231;
            Console.WriteLine(n < m);
            Console.WriteLine(c < d);
        }
    }
}
