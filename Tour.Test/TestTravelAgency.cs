using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TourExercise.Test
{
    [TestClass]
    public class TestTravelAgency
    {
        TravelAgency t;

        [TestInitialize]
        public void InitializeTravelAgency()
        {
             t = new TravelAgency("Tan Ah Huat Travel Far");
        }

        [TestMethod]
        public void TestAddCustomer()
        {
            t.Add(new Customer("Tan Lian Hwee", "Clementi Road", "C10010"));
            t.Add(new Customer("Lim Teck Gee", "Kent Ridge Road", "C10020"));
            t.Add(new Customer("Koh Ghim Moh", "Dover Road", "C10030"));
            t.Add(new Customer("Liat Kim Ho", "West Coast Road", "C10040"));

            Assert.AreEqual(4, t.Customers.Count);
            Assert.AreEqual("Tan Lian Hwee", t.Customers[0].Name);
            Assert.AreEqual("Kent Ridge Road", t.Customers[1].Address);
            Assert.AreEqual("C10030", t.Customers[2].Id);
        }

        [TestMethod]
        public void TestAddTour()
        {
            t.Add(new Tour("Paris", 3400, 3));
            t.Add(new Tour("London", 3200, 3));
            t.Add(new Tour("Munich", 3100, 2));
            t.Add(new Tour("Milan", 3500, 3));

            Assert.AreEqual(4, t.Tours.Count);
            Assert.AreEqual("Paris", t.Tours[0].Name);
            Assert.AreEqual(3200, t.Tours[1].Cost);
            Assert.AreEqual(2, t.Tours[2].Duration);
        }

        [TestMethod]
        public void TestAddTourPackage()
        {
            TestAddTour();

            TourPackage p = new TourPackage("Europe");
            p.ConsistsOf(t.FindTour("London"));
            p.ConsistsOf(t.FindTour("Paris"));

            t.Add(p);

            Assert.AreEqual(5, t.Tours.Count);
            Assert.AreEqual("Europe", t.Tours[4].Name);
            Assert.AreEqual(5940, t.Tours[4].Cost);
            Assert.AreEqual(6, t.Tours[4].Duration);
        }

        [TestMethod]
        public void TestFindTour()
        {
            Tour testTour = new Tour("Paris", 3400, 3);

            TestAddTour();
            Assert.AreEqual(testTour.Name, t.FindTour("Paris").Name);
        }

        [TestMethod]
        public void TestAddTrip()
        {
            t.Add(new Trip(t.FindTour("Paris"), new DateTime(2015, 4, 2), 20));
            t.Add(new Trip(t.FindTour("Munich"), new DateTime(2015, 4, 8), 15));
            t.Add(new Trip(t.FindTour("Europe"), new DateTime(2015, 4, 12), 17));

            Assert.AreEqual(3, t.Trips.Count);
            Assert.AreEqual(new DateTime(2015, 4, 2), t.Trips[0].When);
            Assert.AreEqual(15, t.Trips[1].Maximum);
        }

        [TestMethod]
        public void TestFindTrip()
        {
            TestAddTour();

            Trip testTrip = new Trip(t.FindTour("Paris"), new DateTime(2015, 4, 2), 20);

            TestAddTrip();

            Assert.AreEqual(testTrip.Tour.Name, t.FindTrip("Paris").Tour.Name);
            Assert.AreEqual(testTrip.When, t.FindTrip("Paris").When);
        }

        [TestMethod]
        public void TestMakeBooking()
        {
            TestAddCustomer();
            TestAddTourPackage();
            TestAddTrip();

            t.MakeBooking(t.FindCustomer("Lim Teck Gee"), t.FindTrip("Paris"), 7);
            t.MakeBooking(t.FindCustomer("Liat Kim Ho"), t.FindTrip("Europe"), 2);
            t.MakeBooking(t.FindCustomer("Koh Ghim Moh"), t.FindTrip("Munich"), 1);
            t.MakeBooking(t.FindCustomer("Tan Lian Hwee"), t.FindTrip("Europe"), 3);
        }
    }
}
