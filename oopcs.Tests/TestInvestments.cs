using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Workshops.Workshop6;

namespace oopcs.Tests
{
    [TestClass]
    public class TestInvestments
    {
        Investments investments;

        Coin coin;
        Gold gold;
        Antique antique;

        [TestInitialize]
        public void InitializeTest()
        {
            investments = new Investments();

            coin = new Coin(1, 1.2, new DateTime(2018, 2, 21));
            gold = new Gold(200, 300, new DateTime(2018, 2, 21));
            antique = new Antique(100, 300, new DateTime(2018, 2, 21));
        }

        [TestMethod]
        public void TestAddInvestment()
        {
            investments.AddInvestments(coin);
            investments.AddInvestments(gold);
            investments.AddInvestments(antique);

            Assert.AreEqual(1, investments.ListOfInvestments[0].Cost);
            Assert.AreEqual(300, investments.ListOfInvestments[1].EstimatedValue);
            Assert.AreEqual(new DateTime(2018, 2, 21), investments.ListOfInvestments[2].DateAcquired);
        }

        [TestMethod]
        public void TestGetProfits()
        {
            TestAddInvestment();

            Assert.AreEqual(100, investments.ListOfInvestments[1].Profits);
        }

        [TestMethod]
        public void TestTotalValue()
        {
            TestAddInvestment();

            Assert.AreEqual(601.2, investments.TotalValue());
        }

        [TestMethod]
        public void TestTotalCost()
        {
            TestAddInvestment();

            Assert.AreEqual(301, investments.TotalCost());
        }

        [TestMethod]
        public void TestTotalProfits()
        {
            TestAddInvestment();

            Assert.AreEqual(300.2, investments.TotalProfits());
        }

        [TestMethod, Ignore]
        public void TestToString()
        {
            TestAddInvestment();

            //2/21/2018
            Assert.AreEqual(
                "Workshops.Workshop6.Coin[Cost: 1, Estimated Value: 1.2, Profits: 0.2, Date Acquired: 21-Feb-18 12:00:00 AM]\n" +
                "Workshops.Workshop6.Gold[Cost: 200, Estimated Value: 300, Profits: 100, Date Acquired: 21-Feb-18 12:00:00 AM]\n" +
                "Workshops.Workshop6.Antique[Cost: 100, Estimated Value: 300, Profits: 200, Date Acquired: 21-Feb-18 12:00:00 AM]",
                investments.ToString()
                );
        }
    }
}
