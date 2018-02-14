using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lectures.Day2;

namespace oopcs.Tests
{
    [TestClass]
    public class TestProduct
    {
        Product a, b;

        [TestInitialize]
        public void InitializeProducts()
        {
            a = new Product("Table", "P10001", 20);
            b = new Product("Chair", "P10002");
        }

        [TestMethod]
        public void TestRestock()
        {
            a.Restock(12);
            Assert.AreEqual(32, a.Quantity);

            b.Restock(12);
            Assert.AreEqual(13, b.Quantity);
        }
    }
}
