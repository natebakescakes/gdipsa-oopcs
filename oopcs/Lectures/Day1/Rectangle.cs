using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopcs
{
    class Rectangle
    {
        public int Length { get; set; }
        public int Breadth { get; set; }
        public int Area
        {
            get
            {
                return Length * Breadth;
            }
        }
    }
} 
