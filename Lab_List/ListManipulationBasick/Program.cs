using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mainNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> originalList = new List<int>();
            int count = 0;
            foreach (var item in mainNumbers)
            {
                originalList.Add(item);
                count++;
            }
           
            

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string com = command[0];

                if (com == "end")
                {
                    break;
                }
                else if (com == "Contains" || com == "PrintEven" || com == "PrintOdd" || com == "Filter" || com == "GetSum")
                {
                    while (true)
                    {
                        
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
                                case ">":
                                    filterList = mainNumbers.Where(x => x > value).ToList();
                                    Console.WriteLine(string.Join(' ', filterList));
                                    break;
                                case "<":
                                    filterList = mainNumbers.Where(x => x < value).ToList();
                                    Console.WriteLine(string.Join(' ', filterList));
                                    break;
                                case ">=":
                                    filterList = mainNumbers.Where(x => x >= value).ToList();
                                    Console.WriteLine(string.Join(' ', filterList));
                                    break;
                                case "<=":
                                    filterList = mainNumbers.Where(x => x <= value).ToList();
                                    Console.WriteLine(string.Join(' ', filterList));
                                    break;
                            }
                            
                        }
                        break;
                    }
                }
                else if (com == "Add")
                {
                    int curNum = int.Parse(command[1]);
                    mainNumbers.Add(curNum);
                }
                else if (com == "Remove")
                {
                    int curNum = int.Parse(command[1]);
                    mainNumbers.Remove(curNum);
                }
                else if (com == "RemoveAt")
                {
                    int curNum = int.Parse(command[1]);
                    mainNumbers.RemoveAt(curNum);
                }
                else if (com == "Insert")
                {
                    int value = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    mainNumbers.Insert(index, value);
                }
              
            }
            bool checkIndentic = false;

            for (int i = 0; i <Math.Min(originalList.Count , mainNumbers.Count); i++)
            {
                if (originalList[i] == mainNumbers[i])
                {

                }
                else 
                {
                    checkIndentic = true;
                }
                if (checkIndentic == true)
                {
                    break;
                }
            }
            if (checkIndentic == true)
            {
                Console.WriteLine(string.Join(' ',mainNumbers));
            }
        }
        static public void PrintEvenAndOdd(List<int> allNum, string instruction)
        {
            bool evenOrOdd = false;
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            if (instruction == "PrintEven")
            {
                evenOrOdd = false;
            }
            else if (instruction == "PrintOdd")
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
                Console.WriteLine(string.Join(' ', evenNumbers));
            }
            else if (evenOrOdd == true)
            {
                Console.WriteLine(string.Join(' ', oddNumbers));
            }
        }
    }
}
