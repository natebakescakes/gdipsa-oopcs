using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures.Day4
{
    class Animal
    {
        public void p()
        {
            Console.WriteLine("I am an Animal");
        }
    }

    class Cat : Animal
    {
        public void q()
        {
            Console.WriteLine("I am a cat");
        }
    }

    class Test
    {
        public static void Main()
        {
            Animal v = new Animal();
            Cat w = new Cat();
            Animal v2 = w;

            //Cat w2 = v2;

            int[] hello = new int[10];
        }
    }
}
