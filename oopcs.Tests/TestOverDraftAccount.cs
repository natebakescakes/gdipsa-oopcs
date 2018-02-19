using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Workshops.Workshop4;

namespace oopcs.Tests
{
    [TestClass]
    public class TestOverDraftAccount
    {
        Customer customer;
        OverDraftAccount account;

        [TestInitialize]
        public void InitializeSavingsAccount()
        {
            customer = new Customer("Tan Ah Kow", "123 ABC Road", "SXXXX199D", new DateTime(1991, 10, 31));
            account = new OverDraftAccount("A10001", customer, 1000);
        }

        [TestMethod]
        public void TestCalculateInterestRate()
        {
            Assert.AreEqual(2.5, account.CalculateInterest());
        }

        [TestMethod]
        public void TestCreditInterestPositiveBalance()
        {
            account.CreditInterest();

            Assert.AreEqual(1002.5, account.Balance);
        }

        [TestMethod]
        public void TestCreditInterestNegativeBalance()
        {
            account.Withdraw(2000);
            account.CreditInterest();

            Assert.AreEqual(-1060, account.Balance);
        }
    }
}
