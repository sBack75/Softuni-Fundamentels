using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mainArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "end")
                {
                    break;
                }

                if (command[0] == "exchange")
                {
                    if (mainArray.Length < int.Parse(command[1]))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    int curVal = int.Parse(command[1]);
                    if (curVal > mainArray.Length)
                    {
                        continue;
                    }
                    else
                    {
                        mainArray = Exchange(mainArray, curVal);
                    }
                }
                else if (command[0] == "max")
                {
                    switch (command[1])
                    {
                        case "even":
                            MaxEven(mainArray);
                            break;
                        case "odd":
                            MaxOdd(mainArray);
                            break;
                    }
                }
                else if (command[0] =="min")
                {
                    switch (command[1])
                    {
                        case"even":
                            MinEven(mainArray);
                            break;
                        case "odd":
                            MinOdd(mainArray);
                            break;
                    }
                }
                else if (command[0] == "first")
                {
                    int value = int.Parse(command[1]);
                    if (value > mainArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    switch (command[2])
                    {
                        case "even":
                            FirstEven(mainArray, value);
                            break;

                        case "odd":
                            FirstOdd(mainArray, value);
                            break;
                    }
                }
                else if (command[0] == "last")
                {
                    int value = int.Parse(command[1]);
                    if (value > mainArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    switch (command[2])
                    {
                        case "even":
                            LastEven(mainArray, value);
                            break;

                        case "odd":
                            LastOdd(mainArray, value);
                            break;
                    }
                }
            }
            Console.WriteLine($"[{string.Join(", ", mainArray)}]");

        }
        static int[] Exchange(int[] curArr, int index)
        {
            List<int> changeArr = new List<int>();
            int curIndex = index+1 ;
            for (int i = curIndex; i < curArr.Length; i++)
            {
                changeArr.Add(curArr[i]);
            }
            for (int i = 0; i < curIndex; i++)
            {
                changeArr.Add(curArr[i]);
            }
            curArr = changeArr.ToArray();
            return curArr;
        }
        static void MaxOdd(int[] curArr)
        {

            List<int> oddNumbers = new List<int>();
            List<int> curArray = curArr.ToList();
            for (int i = 0; i < curArr.Length; i++)
            {
                if (curArr[i] % 2 != 0)
                {
                    oddNumbers.Add(curArr[i]);
                }

            }
            if (oddNumbers.Count == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int maxNum = oddNumbers.Max();
                maxNum = curArray.IndexOf(maxNum);
                Console.WriteLine(maxNum);
            }
        }
        static void MaxEven(int[] curArr)
        {
            List<int> evenNumbers = new List<int>();
            List<int> curArray = curArr.ToList();
            for (int i = 0; i < curArr.Length; i++)
            {
                if (curArr[i] % 2 == 0)
                {
                    evenNumbers.Add(curArr[i]);
                }
            }
            if (evenNumbers.Count == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int maxNum = evenNumbers.Max();
                maxNum = curArray.IndexOf(maxNum);
                Console.WriteLine(maxNum);
            }
        }
        static void MinEven (int[]curArr)
        {
            List<int> allEvenNum = new List<int>();

            for (int i = 0; i < curArr.Length; i++)
            {
                if (curArr[i] % 2 == 0)
                {
                    allEvenNum.Add(curArr[i]);
                }
            }
            if (allEvenNum.Count == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int min = allEvenNum.Min();
                min = allEvenNum.IndexOf(min);
                Console.WriteLine(min);
            }
        }
        static void MinOdd(int[] curArr)
        {
            List<int> allOddNum = new List<int>();

            for (int i = 0; i < curArr.Length; i++)
            {
                if (curArr[i] % 2 != 0)
                {
                    allOddNum.Add(curArr[i]);
                }
            }
            if (allOddNum.Count == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int min = allOddNum.Min();
                min = allOddNum.IndexOf(min);
                Console.WriteLine(min);
            }
        }
        static void FirstEven(int[] curArr, int howMuch)
        {
            List<int> firstEven = new List<int>();

            for (int i = 0; i < curArr.Length; i++)
            {
                if (curArr[i] % 2 == 0)
                {
                    firstEven.Add(curArr[i]);
                }
                if (firstEven.Count == howMuch)
                {
                    break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", firstEven)}]");

        }
        static void FirstOdd(int[] curArr, int howMuch)
        {
            List<int> firstOdd = new List<int>();

            for (int i = 0; i < curArr.Length; i++)
            {
                if (curArr[i] % 2 != 0)
                {
                    firstOdd.Add(curArr[i]);
                }
                if (firstOdd.Count == howMuch)
                {
                    break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", firstOdd)}]");

        }
        static void LastEven(int[] curArr, int howMuch)
        {
            int[] revArr = curArr.Reverse().ToArray();
            List<int> lastNum = new List<int>();

            for (int i = 0; i < revArr.Length; i++)
            {
                if (revArr[i] % 2 == 0)
                {
                    lastNum.Add(revArr[i]);
                }
                if (lastNum.Count == howMuch)
                {
                    break;
                }
            }
            lastNum.Reverse();
            Console.WriteLine($"[{string.Join(", ", lastNum)}]");
        }
        static void LastOdd(int[] curArr, int howMuch)
        {
            int[] revArr = curArr.Reverse().ToArray();
            List<int> lastNum = new List<int>();

            for (int i = 0; i < revArr.Length; i++)
            {
                if (revArr[i] % 2 != 0)
                {
                    lastNum.Add(revArr[i]);
                }
                if (lastNum.Count == howMuch)
                {
                    break;
                }
            }
            lastNum.Reverse();
            Console.WriteLine($"[{string.Join(", ", lastNum)}]");
        }
    }
}
