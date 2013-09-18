using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            HousePlant tree = new HousePlant();
            tree.Name = "Tree";
            tree.Fed = false;
            tree.Price = 29.99;

            HousePlant fern = new HousePlant();
            fern.Name = "fern";
            tree.Fed = false;
            tree.Price = 42.42;

            HousePlant ivy = new HousePlant();
            ivy.Name = "ivy";
            fern.Fed = true;
            fern.Price = 9000.01;
        }
    }
}