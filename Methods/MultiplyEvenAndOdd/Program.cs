using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiplyEvenAndOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            numbers = Math.Abs(numbers);
            OddAndEven(numbers);
            
        }
        static void OddAndEven(int numbers)
        {
            List<int> elements = new List<int>();
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            int index = numbers.ToString().Length;
            for (int i = 0; i < index; i++)
            {
                int curNum = numbers % 10;
                numbers = numbers / 10;
                elements.Add(curNum);
            }
            elements.Reverse();
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % 2 == 0)
                {
                    even.Add(elements[i]);
                }
                else
                {
                    odd.Add(elements[i]);
                }
            }
            int evenSum = even.Sum();
            int oddSum = odd.Sum();

            

            
            Console.WriteLine(evenSum * oddSum);
        }
    }
}
