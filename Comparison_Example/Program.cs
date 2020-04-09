using System;
using System.Collections.Generic;
using Comparison_Example.Entities;
namespace Comparison_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List < Product > list = new List<Product>();
            Product p1 = new Product("TV", 900.00);
            Product p2 = new Product("Notebook", 1200.00);
            Product p3 = new Product("Tablet", 450.00);
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);

            list.Sort(); //Icomparable

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
