using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Workshops.Workshop3;

namespace oopcs.Tests
{
    [TestClass]
    public class TestRational
    {
        [TestMethod]
        public void TestRationalAdditionTrue()
        {
            Assert.AreEqual(new Rational(3, 4), new Rational(1, 4) + new Rational(2, 4));
            Assert.AreEqual(new Rational(1, 1), new Rational(1, 2) + new Rational(1, 2));
            Assert.AreEqual(new Rational(1, 2), new Rational(1, 4) + new Rational(2, 8));
        }

        [TestMethod]
        public void TestRationalAdditionFalse()
        {
            Assert.AreNotEqual(new Rational(3, 5), new Rational(3, 5) - new Rational(1, 5));
        }

        [TestMethod]
        public void TestRationalSubtractionTrue()
        {
            Assert.AreEqual(new Rational(3, 8), new Rational(2, 4) - new Rational(1, 8));
            Assert.AreEqual(new Rational(3, 1), new Rational(22, 7) - new Rational(1, 7));
        }

        [TestMethod]
        public void TestRationalSubtractionFalse()
        {
            Assert.AreNotEqual(new Rational(2, 9), new Rational(1, 3) - new Rational(2, 9));
        }

        [TestMethod]
        public void TestRationalMultiplicationTrue()
        {
            Assert.AreEqual(new Rational(1, 4), new Rational(1, 2) * new Rational(1, 2));
        }

        [TestMethod]
        public void TestRationalMultiplicationFalse()
        {
            Assert.AreNotEqual(new Rational(1, 2), new Rational(1, 2) * new Rational(1, 2));
        }

        [TestMethod]
        public void TestRationalDivisionTrue()
        {
            Assert.AreEqual(new Rational(1, 1), new Rational(1, 2) / new Rational(1, 2));
        }

        [TestMethod]
        public void TestRationalDivisionFalse()
        {
            Assert.AreNotEqual(new Rational(1, 3), new Rational(1, 3) / new Rational(3, 1));
        }

        [TestMethod]
        public void TestComplexOperations()
        {
            Rational a = new Rational(1, 2);
            Rational b = new Rational(1, 3);
            Rational c = new Rational(5, 6);

            Assert.AreEqual(new Rational(21, 12), a * c / b + a);
        }
    }
}
