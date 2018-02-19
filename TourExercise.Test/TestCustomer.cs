using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TourExercise;

namespace TourExercise.Test
{
    [TestClass]
    public class TestCustomer
    {
        Customer a, b;

        [TestInitialize]
        public void InitializeCustomers()
        {
            a = new Customer("Tan Lian Hwee", "Clementi Road", "C10010");
            b = new Customer("Lim Teck Gee", "Kent Ridge Road", "C10020");
        }

        [TestMethod]
        public void TestName()
        {
            Assert.AreEqual("Tan Lian Hwee", a.Name);
            Assert.AreEqual("Lim Teck Gee", b.Name);
        }

        [TestMethod]
        public void TestAddresss()
        {
            Assert.AreEqual("Clementi Road", a.Address);
            Assert.AreEqual("Kent Ridge Road", b.Address);
        }

        [TestMethod]
        public void TestId()
        {
            Assert.AreEqual("C10010", a.Id);
            Assert.AreEqual("C10020", b.Id);
        }
    }
}
