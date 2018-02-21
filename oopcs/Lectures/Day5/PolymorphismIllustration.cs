using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures.Day5
{
    public class A
    {
        protected int x;

        public A(int x) { this.x = x; }

        public void P()
        {
            Console.WriteLine($"A.P[{x}]");
        }
        public void Q()
        {
            x += 10;
            P();
        }
    }

    public class B : A
    {
        public B(int x) : base(x) { }

        public new void P()
        {
            Console.WriteLine($"B.P[{x}]");
        }
    }

    
}
