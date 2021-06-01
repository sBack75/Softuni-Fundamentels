using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        public static object ToArray { get; private set; }

        static void Main(string[] args)
        {
            string[] products =
            {
                "coffee","water","coke","snack"
            };
            double[] price =
            {
                1.50 , 1 , 1,40 , 2
            };
            string orderNeed = Console.ReadLine();
            int howMuch = int.Parse(Console.ReadLine());
            CalculatePrice(products, price, howMuch, orderNeed);
        }
        static void CalculatePrice (string[] products , double [] prices,int howMuch, string orderNeed)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == orderNeed)
                {
                    double total = prices[i] * howMuch;
                    Console.WriteLine($"{total:f2}");
                }
            }
        }
    }
}
