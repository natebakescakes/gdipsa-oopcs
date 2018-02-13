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
        [TestInitialize]
        public void InitializeBankAccount()
        {
            a = new BankAccount("001-001-001", "Tan Ah Kow", 2000);
            b = new BankAccount("001-001-002", "Kim Keng Lee", 5000);
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
        public void TestWithdrawScenario()
        {
            a.Withdraw(200);
            Assert.AreEqual(1800, a.Balance);
            Assert.AreEqual(5000, b.Balance);
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
