using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch7Problems
{
    class Circle
    {
        private double radius;

        public double Radius 
        {
            get
            {
                return Radius;
            }
            set
            {
                Radius = value;
            }
        }

        public double Diameter
        {
            get
            {
                return radius * 2;
            }
        }
        public double Area
        {
            get
            {
                return Math.PI * radius * radius;
            }
        }
    }
}
