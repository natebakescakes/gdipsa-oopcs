using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshops.Workshop6
{
    public interface IShapes
    {
        double Area { get; }
        double Perimeter { get; }
    }

    public class Triangle : IShapes
    {
        private double side1, side2, side3;

        public Triangle(double side1, double side2, double side3)
        {
            // Triangle inequality theorum
            if (side1 + side2 <= side3 || side2 + side3 <= side1 || side3 + side1 <= side2)
                throw new ArgumentException("The sum of any 2 sides must be greater than the third side");
            else if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("All sides must be positive real number");

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        // Heron's Formula
        public double Area
        {
            get
            {
                double p = Perimeter / 2;

                return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            }
        }

        public double Perimeter { get { return side1 + side2 + side3; } }
    }

    public class Rectangle : IShapes
    {
        private double length, breadth;

        public Rectangle(double length, double breadth)
        {
            if (length <= 0 || breadth <= 0)
                throw new ArgumentException("Length and breadth must be positive real number");

            this.length = length;
            this.breadth = breadth;
        }

        public double Area { get { return length * breadth; } }

        public double Perimeter { get { return (length + breadth) * 2; } }
    }

    public class Circle : IShapes
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be a real positive number");

            this.radius = radius;
        }

        public double Area { get { return Math.PI * Math.Pow(radius, 2); } }
        public double Perimeter { get { return 2 * Math.PI * radius; } }
    }
}
