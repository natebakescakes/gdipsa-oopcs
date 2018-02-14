using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopcs.Day1
{
    class Program
    {
        /* Instantiates a Coin object
         * Flips 100 times, counts the number of times coin flips land on heads and tails
         * Calculates the probability that the no. of times headCount == tailCount out of 
         * a 1000 simulations.
         */ 
        static void Main(string[] args)
        {
            #region Coin()
            //Coin c = new Coin();

            //int sameFaceCount = 0;
            //int simulationCount = 1000000;

            //for (int j = 0; j < simulationCount; j++)
            //{
            //    int headCount = 0, tailCount = 0;

            //    for (int i = 0; i < 100; i++)
            //    {
            //        c.Flip();
            //        switch (c.Face)
            //        {
            //            case Coin.FaceType.Heads:
            //                headCount++;
            //                break;
            //            case Coin.FaceType.Tails:
            //                tailCount++;
            //                break;
            //        }
            //    }
            //    //Console.WriteLine($"Heads: {headCount}, Tails: {tailCount}");

            //    if (headCount == tailCount)
            //        sameFaceCount++;
            //}

            //Console.WriteLine(
            //    $"No. of Times Face Count is the same: {sameFaceCount}/{simulationCount}, " +
            //    $"{(sameFaceCount / (double)simulationCount * 100):0.00}%."
            //);
            #endregion

            #region Person()
            //Person p1 = new Person("Tan Ah How", 24);
            //p1.Age = 10;
            //Console.WriteLine(p1.Age);
            #endregion

            #region BankAccount()
            //BankAccount a = new BankAccount("001-001-001", "Tan Ah Kow", 2000);
            //BankAccount b = new BankAccount("001-001-002", "Kim Keng Lee", 5000);
            //Console.WriteLine(a.Show());
            //Console.WriteLine(b.Show());
            //a.Deposit(100);
            //Console.WriteLine(a.Show());
            //a.Withdraw(200);
            //Console.WriteLine(a.Show());
            //a.TransferTo(300, b);
            //Console.WriteLine(a.Show());
            //Console.WriteLine(b.Show());
            #endregion
        }
    }
}
