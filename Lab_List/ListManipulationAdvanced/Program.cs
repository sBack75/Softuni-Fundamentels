using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mainNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "end")
                {
                    break;
                }
                else if (command[0] == "Contains")
                {
                    int value = int.Parse(command[1]);
                    if (mainNumbers.Contains(value))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command[0] == "PrintEven" || command[0] == "PrintOdd")
                {
                    string instruction = command[0];
                    PrintEvenAndOdd(mainNumbers, instruction);
                }
                else if (command[0] == "GetSum")
                {
                    int sum = mainNumbers.Sum();
                    Console.WriteLine(sum);
                }
                else if (command[0] == "Filter")
                {
                    string instuction = command[1];
                    int value = int.Parse(command[2]);
                    List<int> filterList = new List<int>();
                    switch (instuction)
                    {
                        case">":
                            filterList = mainNumbers.Where(x=>x > value).ToList();
                            Console.WriteLine(string.Join(' ',));
                            break;
                        case "<":
                            break;
                        case ">=":
                            break;
                        case "<=":
                            break;
                    }
                }
            }
        }
        static void PrintEvenAndOdd(List<int> allNum , string instruction)
        {
            bool evenOrOdd = false;
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            if (instruction == "PrintEven")
            {
                evenOrOdd = false;
            }
            else if (instruction =="PrintOdd")
            {
                evenOrOdd = true;
            }
            for (int i = 0; i < allNum.Count; i++)
            {
                if (allNum[i] % 2 == 0)
                {
                    evenNumbers.Add(allNum[i]);
                }
                else
                {
                    oddNumbers.Add(allNum[i]);
                }
            }
            if (evenOrOdd == false)
            {
                Console.WriteLine(string.Join(' ',evenNumbers)) ;
            }
            else if (evenOrOdd == true)
            {
                Console.WriteLine(string.Join(' ', oddNumbers));
            }
        }

    }
}
