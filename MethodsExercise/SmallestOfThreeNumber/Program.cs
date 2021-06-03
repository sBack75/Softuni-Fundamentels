    using System;

    namespace SmallestOfThreeNumber
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] smallNum =new int [3];

                for (int i = 0; i < smallNum.Length; i++)
                {
                    smallNum[i] = int.Parse(Console.ReadLine());
                }
                smallestNum(smallNum);


            }
            static void smallestNum (int[] smallNum)
            {
                int minNum = int.MaxValue;
                for (int i = 0; i < 3; i++)
                {
                    if (smallNum[i] < minNum)
                    {
                        minNum = smallNum[i];
                    }
                }
                Console.WriteLine(minNum);
            }
        }
    }
