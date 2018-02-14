using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TourExercise;

namespace TourExercise.Test
{
    [TestClass]
    public class TestTourGuide
    {
        TourGuide c, d;
        [TestInitialize]
        public void InitializeTourGuide()
        {
            c = new TourGuide("Koh Ghim Moh", "Dover Road", 3400);
            d = new TourGuide("Liat Kim Ho", "West Coast Road", 2700);
        }

        [TestMethod]
        public void TestName()
        {
            Assert.AreEqual("Koh Ghim Moh", c.Name);
            Assert.AreEqual("Liat Kim Ho", d.Name);
        }

        [TestMethod]
        public void TestAddresss()
        {
            Assert.AreEqual("Dover Road", c.Address);
            Assert.AreEqual("West Coast Road", d.Address);
        }

        [TestMethod]
        public void TestSalary()
        {
            Assert.AreEqual(3400, c.Salary);
            Assert.AreEqual(2700, d.Salary);
        }
    }
}
