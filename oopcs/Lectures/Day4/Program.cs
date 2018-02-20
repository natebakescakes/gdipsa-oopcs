using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures.Day4
{
    class A
    {
        //private int x; // If private, not accessible outside of class
        protected int y; // If protected, accessible in all derived classes
    }

    class B : A
    {
        public void p()
        {
            //x = 1;
            y = 2;
        }
    }

    class C : B
    {
        public void q()
        {
            //x = 1;
            y = 2;
        }
    }

    class Program
    {
        static int[] w(int size)
        {
            int[] m = new int[size];

            for (int i = 0; i < size; i++)
            {
                m[i] = i * 2;
            }

            return m;
        }

        static ArrayList v(int size)
        {
            ArrayList b = new ArrayList();

            for (int i = 0; i < size; i++)
            {
                b.Add(i * 2);
            }

            for (int i = 0; i < b.Count; i++)
            {
                Console.WriteLine(b[i]);
            }

            return b;
        }

        static int[] GrowDouble(int[] existing)
        {
            int[] newArr = new int[existing.Length * 2];

            for (int i = 0; i < existing.Length; i++)
            {
                newArr[i] = existing[i];
            }

            return newArr;
        }

        static void Main(string[] args)
        {
            int[] z = w(10);

            for (int i = 0; i < z.Length; i++)
            {
                Console.WriteLine(z[i]);
            }
        }
    }
}
