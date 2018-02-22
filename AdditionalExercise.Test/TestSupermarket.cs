using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Workshops.AdditionalExercise;

namespace AdditionalExercise.Test
{
    [TestClass]
    public class TestSupermarket
    {
        Customer customer;
        Supermarket supermarket;

        [TestInitialize]
        public void InitializeCustomer()
        {
            customer = new Customer("Tan Ah Kow");

            supermarket = new Supermarket("Sheng Siong", 0.05);
        }

        [TestMethod]
        public void TestAddProduct()
        {
            supermarket.AddProduct(new Product("Beans", "P10001", 1), 10);
        }

        [TestMethod]
        public void TestFindProduct()
        {
            TestAddProduct();

            Assert.AreEqual("Beans", supermarket.FindProduct("Beans").Name);
        }

        [TestMethod]
        public void TestCheckOutCustomer()
        {
            TestAddProduct();

            customer.AddToBasket(supermarket, supermarket.FindProduct("Beans"), 5);

            supermarket.CheckOutCustomer(customer);

            Assert.AreEqual(5, supermarket.CheckInventoryLevel(supermarket.FindProduct("Beans")));
            Assert.AreEqual(5, customer.TotalSpent);
        }

        [TestMethod]
        public void TestCheckOutMember()
        {
            TestAddProduct();

            TestAddMember();

            customer.AddToBasket(supermarket, supermarket.FindProduct("Beans"), 5);

            supermarket.CheckOutCustomer(customer);

            Assert.AreEqual(5, supermarket.CheckInventoryLevel(supermarket.FindProduct("Beans")));
            Assert.AreEqual(4.75, customer.TotalSpent);
        }

        [TestMethod]
        public void TestCheckInventoryLevel()
        {
            TestAddProduct();

            Assert.AreEqual(10, supermarket.CheckInventoryLevel(supermarket.FindProduct("Beans")));
        }

        [TestMethod]
        public void TestTotalRevenue()
        {
            TestCheckOutCustomer();

            Assert.AreEqual(5, supermarket.TotalRevenue);
        }

        [TestMethod]
        public void TestTotalRevenueMember()
        {
            TestCheckOutMember();

            Assert.AreEqual(4.75, supermarket.TotalRevenue);
        }

        [TestMethod]
        public void TestAddMember()
        {
            supermarket.AddMember(customer);
        }

        [TestMethod]
        public void TestFindMember()
        {
            TestAddMember();

            Assert.AreEqual(customer, supermarket.FindMember("Tan Ah Kow"));
        }
    }
}
