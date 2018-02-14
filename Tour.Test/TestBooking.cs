using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TourExercise.Test
{
    [TestClass]
    public class TestBooking
    {
        Customer c1, c2;
        Tour t1;
        Trip h1;
        Booking b1, b2;

        [TestInitialize]
        public void InitializeBooking()
        {
            c1 = new Customer("Tan Lian Hwee", "Clementi Road", "C10010");
            c2 = new Customer("Lim Teck Gee", "Kent Ridge Road", "C10020");

            t1 = new Tour("Paris", 3400, 3);

            h1 = new Trip(t1, new DateTime(2015, 5, 2), 20);

            
        }

        [TestMethod]
        public void TestCost()
        {
            b1 = new Booking(c1, h1, 10);

            Assert.AreEqual(32300, b1.Cost);

            b2 = new Booking(c1, h1, 3);

            Assert.AreEqual(10200, b2.Cost);
        }
    }
}
