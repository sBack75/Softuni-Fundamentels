using System;

namespace GreaterFromValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            if (command == "int")
            {
                int numberOne = int.Parse(Console.ReadLine());
                int numberTwo = int.Parse(Console.ReadLine());
                ReturnMostInt(numberOne, numberTwo);
            }
            else if (command == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                ReturnMostChar(firstChar, secondChar);

            }
            else if (command == "string")
            {
                string firstStr = Console.ReadLine();
                string secondStr = Console.ReadLine();
                ReturnMostString(firstStr, secondStr);
            }
        }
        static void ReturnMostInt (int numOne , int numTwo)
        {
            if (numOne > numTwo)
            {
                Console.WriteLine(numOne);
            }
            else
            {
                Console.WriteLine(numTwo);
            }
        }
        static void ReturnMostChar ( char firstChar , char secondChar)
        {
            if (firstChar > secondChar)
            {
                Console.WriteLine(firstChar);
            }
            else
            {
                Console.WriteLine(secondChar);
            } 
        }
        static void ReturnMostString ( string firstString , string secondString)
        {
            if (firstString.Length > secondString.Length)
            {
                Console.WriteLine(firstString);
            }
            else
            {
                Console.WriteLine(secondString);
            }
        }
    }
}
