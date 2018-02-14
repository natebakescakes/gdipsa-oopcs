using System;
using Workshops.Workshop3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace oopcs.Tests
{
    [TestClass]
    public class TestCustomer
    {
        Customer customer1, customer2, customer3;

        [TestInitialize]
        public void InitializeCustomer()
        {
            customer1 = new Customer("Nathan Khoo", "123, ABC Road", "XXX20", new DateTime(1991, 10, 31));
            customer2 = new Customer("Tan Ah Kow", "20, Seaside Road", "XXX20", new DateTime(1989, 10, 11));
            customer3 = new Customer("Kim Lee Keng", "2, Rich View", "XXX9F", new DateTime(1993, 4, 25));
        }

        [TestMethod]
        public void TestGetAge()
        {
            Assert.AreEqual(26, customer1.GetAge());
            Assert.AreEqual(28, customer2.GetAge());
            Assert.AreEqual(24, customer3.GetAge());
        }
    }
}
