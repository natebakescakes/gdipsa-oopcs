using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Workshops.Workshop3;

namespace oopcs.Tests
{
    [TestClass]
    public class TestBankAccount
    {
        private BankAccount a;
        private BankAccount b;
        private Customer customer1;
        private Customer customer2;

        [TestInitialize]
        public void InitializeBankAccount()
        {
            customer1 = new Customer("Tan Ah Kow", "20, Seaside Road", "XXX20", new DateTime(1989, 10, 11));
            customer2 = new Customer("Kim Lee Keng", "2, Rich View", "XXX9F", new DateTime(1993, 4, 25));

            a = new BankAccount("001-001-001", customer1, 2000);
            b = new BankAccount("001-001-002", customer2, 5000);
        }

        [TestMethod]
        public void TestBankAccountInit()
        {
            Assert.AreEqual(2000, a.Balance);
            Assert.AreEqual(5000, b.Balance);
        }

        [TestMethod]
        public void TestDepositScenario()
        {
            a.Deposit(100);
            Assert.AreEqual(2100, a.Balance);
            Assert.AreEqual(5000, b.Balance);
        }

        [TestMethod]
        public void TestWithdrawLegal()
        {
            a.Withdraw(200);
            Assert.AreEqual(1800, a.Balance);
            Assert.AreEqual(5000, b.Balance);
        }

        [TestMethod]
        public void TestWithdrawIllegal()
        {
            Assert.ThrowsException<ArgumentException>(() => a.Withdraw(2100));
        }

        [TestMethod]
        public void TestTransferScenario()
        {
            a.TransferTo(300, b);
            Assert.AreEqual(1700, a.Balance);
            Assert.AreEqual(5300, b.Balance);
        }
    }
}
