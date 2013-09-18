using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza();
            pizza.Topping = "pepperoni";

            Pizza size = new Pizza();
            pizza.Diameter = 12;

            Pizza price = new Pizza();
            pizza.Price = 13.99;
        }
    }
}
