using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures.Day3
{
    public class Rectangle
    {
        private int length, width;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        protected int Length
        {
            get { return length; }
        }

        protected int Width
        {
            get { return width; }
        }

        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        public int GetArea()
        {
            return length * width;
        }
    }

    public class Parallelogram : Rectangle
    {
        private int angle;

        public Parallelogram(int length, int width, int angle) : base(length, width)
        {
            this.angle = angle;
        }
        
        public int Angle
        {
            get { return angle; }
        }

        public new int GetArea()
        {
            return (int)(base.GetArea() * Math.Sin(angle * Math.PI / 180));
        }
    }
}
