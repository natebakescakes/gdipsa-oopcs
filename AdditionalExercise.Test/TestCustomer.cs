using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Workshops.AdditionalExercise;

namespace AdditionalExercise.Test
{
    [TestClass]
    public class TestCustomer
    {
        Customer customer;
        Supermarket supermarket;

        [TestInitialize]
        public void InitializeCustomer()
        {
            customer = new Customer("Tan Ah Kow");

            supermarket = new Supermarket("Sheng Siong");
            supermarket.AddProduct(new Product("Beans", "P10001", 1), 10);

            customer.AddToBasket(supermarket, supermarket.FindProduct("Beans"), 5);
        }

        [TestMethod]
        public void TestTotalSpent()
        {
            Assert.AreEqual(0, customer.TotalSpent);
            Assert.ThrowsException<ArgumentException>(() => customer.TotalSpent = -10);
        }

        [TestMethod]
        public void TestBasketCost()
        {
            Assert.AreEqual(5, customer.BasketCost);
        }

        [TestMethod]
        public void TestAddToBasket()
        {
            Assert.IsTrue(customer.Basket.ContainsKey(supermarket.FindProduct("Beans")));
        }

        [TestMethod]
        public void TestResetBasket()
        {
            customer.ResetBasket();

            Assert.AreEqual(0, customer.Basket.Count);
        }
    }
}
