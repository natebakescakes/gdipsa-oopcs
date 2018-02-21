using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Workshops.Workshop6;

namespace oopcs.Tests
{
    [TestClass]
    public class TestShapes
    {
        IShapes triangle, rectangle, circle;

        [TestMethod]
        public void TestTriangleInitialization()
        {
            triangle = new Triangle(3, 3, 3);
        }

        [TestMethod]
        public void TestInvalidTriangle()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 2, 3));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, 2, 3));
        }

        [TestMethod]
        public void TestTriangleArea()
        {
            TestTriangleInitialization();

            Assert.AreEqual(3.8971, triangle.Area, 0.0001);
        }

        [TestMethod]
        public void TestTrianglePerimeter()
        {
            TestTriangleInitialization();

            Assert.AreEqual(9, triangle.Perimeter);
        }

        [TestMethod]
        public void TestRectangleInitialization()
        {
            rectangle = new Rectangle(1, 2);
        }

        [TestMethod]
        public void TestInvalidRectangle()
        {
            Assert.ThrowsException<ArgumentException>(() => new Rectangle(-1, 2));
        }

        [TestMethod]
        public void TestRectangleArea()
        {
            TestRectangleInitialization();

            Assert.AreEqual(2, rectangle.Area);
        }

        [TestMethod]
        public void TestRectanglePerimeter()
        {
            TestRectangleInitialization();

            Assert.AreEqual(6, rectangle.Perimeter);
        }

        [TestMethod]
        public void TestCircleInitialization()
        {
            circle = new Circle(10);
        }

        [TestMethod]
        public void TestInvalidCircle()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-1));
        }

        [TestMethod]
        public void TestCircleArea()
        {
            TestCircleInitialization();

            Assert.AreEqual(314.16, circle.Area, 0.01);
        }

        [TestMethod]
        public void TestCirclePerimeter()
        {
            TestCircleInitialization();

            Assert.AreEqual(62.83, circle.Perimeter, 0.01);
        }
    }
}
