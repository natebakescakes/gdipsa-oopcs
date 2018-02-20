using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Workshops.Workshop4;
using Workshops.Workshop5;

namespace oopcs.Tests
{
    [TestClass]
    public class TestBankBranch
    {
        Customer customer1, customer2, customer3;

        CurrentAccount currentAccount;
        SavingsAccount savingsAccount;
        OverDraftAccount overDraftAccount;

        BankBranch bankBranch;

        [TestInitialize]
        public void InitializeSavingsAccount()
        {
            customer1 = new Customer("Tan Ah Kow", "123 ABC Road", "SXXXX199D", new DateTime(1991, 10, 31));
            customer2 = new Customer("Tan Ah Yow", "123 XYZ Road", "SXXXX123E", new DateTime(1993, 12, 02));
            customer3 = new Customer("Tan Ah Lao", "321 ABX Road", "SXXXX321F", new DateTime(1980, 3, 23));

            currentAccount = new CurrentAccount("A10001", customer1, 1000);
            savingsAccount = new SavingsAccount("A10002", customer2, 3000);
            overDraftAccount = new OverDraftAccount("A10003", customer3, -1000);

            bankBranch = new BankBranch("DBS Branch 1", "Tan Ah Seng");
        }
        [TestMethod]
        public void TestAddAccount()
        {
            bankBranch.AddAccount(currentAccount);
            bankBranch.AddAccount(savingsAccount);
            bankBranch.AddAccount(overDraftAccount);
        }

        [TestMethod]
        public void TestTotalDeposits()
        {
            TestAddAccount();

            Assert.AreEqual(3000, bankBranch.TotalDeposits());
        }

        [TestMethod]
        public void TestToString()
        {
            TestAddAccount();

            Assert.AreEqual(
                "A10001: Tan Ah Kow\nA10002: Tan Ah Yow\nA10003: Tan Ah Lao",
                bankBranch.ToString());
        }

        [TestMethod]
        public void TestTotalInterestPaid()
        {
            TestAddAccount();

            Assert.AreEqual(32.5, bankBranch.TotalInterestPaid());
        }

        [TestMethod]
        public void TestTotalInterestEarned()
        {
            TestAddAccount();

            Console.WriteLine(bankBranch.BankAccounts[2]);

            Assert.AreEqual(60, bankBranch.TotalInterestEarned());
        }
    }
}
