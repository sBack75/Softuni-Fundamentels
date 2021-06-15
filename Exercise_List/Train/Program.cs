using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passengers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int capacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] =="end" )
                {
                    break;
                }
                if (command[0] == "Add")
                {
                    int number = int.Parse(command[1]);
                    passengers.Add(number);
                }
                else
                {
                    int number = int.Parse(command[0]);
                    for (int i = 0; i < passengers.Count; i++)
                    {
                        if (passengers[i] + number <= capacity)
                        {
                        passengers[i] += number;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(' ',passengers));

        }
    }
}
