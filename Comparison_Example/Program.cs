﻿using System;
using System.Collections.Generic;
using Comparison_Example.Entities;
namespace Comparison_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List < Product > list = new List<Product>();
           //Product p1 = new Product("TV", 900.00);
            //Product p2 = new Product("Notebook", 1200.00);
            //Product p3 = new Product("Tablet", 450.00);
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            list.Sort((p1,p2)=> p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); //Icomparable

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        
    }
}
