using System;
using System.Collections.Generic;
using System.Linq;

namespace GausTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> newList = new List<int>();

            if (numbers.Count % 2 == 0)
            {
                for (int i = 0; i < numbers.Count / 2; i++)
                {
                    int index = numbers.Count - 1;
                    newList.Add(numbers[i] + numbers[index - i]);
                    
                }
            }
            else
            {
                int indexF = (numbers.Count-1)/2;

                for (int i = 0; i < indexF; i++)
                {
                    int index = numbers.Count - 1;
                    newList.Add(numbers[i] + numbers[index - i]);

                }
                newList.Add(indexF + 1);
            }
            Console.WriteLine(string.Join(' ',newList));
        }
    }
}
