using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TourExercise.Test
{
    [TestClass]
    public class TestTourPackage
    {
        TourPackage p;
        Tour t1, t2, t3, t4;

        [TestInitialize]
        public void InitializeTourPackage()
        {
            p = new TourPackage("Europe");
            t1 = new Tour("Paris", 3400, 3);
            t2 = new Tour("London", 3200, 3);
            t3 = new Tour("Munich", 3100, 2);
            t4 = new Tour("Milan", 3500, 3);
        }

        [TestMethod]
        public void TestConsistsOf()
        {
            p.ConsistsOf(t1);
            p.ConsistsOf(t2);

            List<Tour> testList = new List<Tour>();
            testList.Add(t1);
            testList.Add(t2);

            CollectionAssert.AreEqual(testList, p.ListOfTours);
        }

        [TestMethod]
        public void TestCost()
        {
            p.ConsistsOf(t1);
            p.ConsistsOf(t2);

            Assert.AreEqual(5940, p.Cost);
        }

        [TestMethod]
        public void TestDuration()
        {
            p.ConsistsOf(t1);
            p.ConsistsOf(t2);

            Assert.AreEqual(6, p.Duration);
        }

        [TestMethod]
        public void TestToString()
        {
            p.ConsistsOf(t1);
            p.ConsistsOf(t2);

            //"Name: {name}, Cost: {cost}, Duration: {duration}"
            Assert.AreEqual("Name: Europe, Cost: 5940, Duration: 6", p.ToString());
        }
    }
}
