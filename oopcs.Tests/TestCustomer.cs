using System;
using Workshops.Workshop3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace oopcs.Tests
{
    [TestClass]
    public class TestCustomer
    {
        [TestMethod]
        public void TestGetAge()
        {
            Customer c = new Customer("Tan Ah Kow", "20, Seaside Road", "XXX20", new DateTime(1991, 10, 31));
            Assert.AreEqual(26, c.GetAge());
        }
    }
}
