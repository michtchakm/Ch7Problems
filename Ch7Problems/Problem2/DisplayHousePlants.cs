using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch7Problems
{
    class Pizza
    {
        private string topping;
        private int diameter;
        private double price;

        public string Topping
        {
            get
            {
                return topping;
            }
            set
            {
                topping = value;
            }
        }

        public int Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = 12;
            }
        }
        public double Price
        {
            get
            {
                return Price;
            }
            set
            {
                Price = 13.99;
            }
        }
    }
}

