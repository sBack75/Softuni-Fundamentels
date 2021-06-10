using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            List<string> myProduct = new List<string>();


            for (int i = 1; i <= numbers; i++)
            {
                string curProduct = Console.ReadLine();

                myProduct.Add(curProduct);
            }
            int counter = 1;
            myProduct = myProduct.OrderBy(x => x).ToList() ;
            foreach (var item in myProduct)
            {
                Console.WriteLine($"{counter}.{item}");
                counter++;
            }
        }
    }
}
