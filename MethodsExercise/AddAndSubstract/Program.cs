using System;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
           
            Console.WriteLine(Subratact(numberOne,numberTwo,numberThree));
        }
        static int Subratact(int numOne , int numTwo , int numThree)
        {
            int result = (numOne + numTwo) - numThree;
            return result;
        }
    }
}
