using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Workshops.Workshop4;

namespace oopcs.Tests
{
    [TestClass]
    public class TestCurrentAccount
    {
        Customer customer;
        CurrentAccount account;

        [TestInitialize]
        public void InitializeSavingsAccount()
        {
            customer = new Customer("Tan Ah Kow", "123 ABC Road", "SXXXX199D", new DateTime(1991, 10, 31));
            account = new CurrentAccount("A10001", customer, 1000);
        }

        [TestMethod]
        public void TestCalculateInterestRate()
        {
            Assert.AreEqual(2.5, account.CalculateInterest());
        }

        [TestMethod]
        public void TestCreditInterest()
        {
            account.CreditInterest();

            Assert.AreEqual(1002.5, account.Balance);
        }
    }
}
