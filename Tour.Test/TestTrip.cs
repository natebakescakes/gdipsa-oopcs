using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TourExercise.Test
{
    [TestClass]
    public class TestTrip
    {
        Customer c1;
        Trip holiday1, holiday2;
        Tour t1;

        [TestInitialize]
        public void InitializeTrip()
        {
            c1 = new Customer("Tan Lian Hwee", "Clementi Road", "C10010");

            t1 = new Tour("Paris", 3400, 3);

            holiday1 = new Trip(t1, new DateTime(2015, 5, 2), 20);
            holiday2 = new Trip(t1, new DateTime(2015, 6, 17), 20);
        }

        [TestMethod]
        public void TestBook()
        {
            holiday1.Book(c1, 15);

            Assert.AreEqual(15, holiday1.Bookings[0].NoOfTravellers);
            Assert.AreEqual(c1, holiday1.Bookings[0].Customer);
            Assert.AreEqual(holiday1, holiday1.Bookings[0].Trip);
        }

        [TestMethod]
        public void TestBookException()
        {
            Assert.ThrowsException<ApplicationException>(() => holiday1.Book(c1, 21));
        }

        [TestMethod]
        public void TestGetRevenue()
        {
            holiday1.Book(c1, 15);
            holiday1.Book(c1, 15);
            Assert.AreEqual(96900, holiday1.GetRevenue());
        }
    }
}
