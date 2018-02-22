using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures.Day6
{
    class StringLengthComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length.CompareTo(y.Length);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //string[] wordList = { "able", "ale", "apple", "bale", "kangaroo" };
            //Array.Sort(wordList, new StringLengthComparer());
            //Array.Reverse(wordList);

            //Console.WriteLine(String.Join(", ", wordList));

            //Customer a, b;
            //a = new Customer();
            //b = new Customer();

            //Console.WriteLine(a == b);
            //Console.WriteLine(a.Equals(b));
        }
    }

    //class Customer
    //{
    //    private string name;
    //}
}
