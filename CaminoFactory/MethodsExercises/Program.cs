using System;
using System.Linq;
namespace MethodsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            MostSmallNum(numberOne, numberTwo, numberThree);
        }
        static void MostSmallNum(int numOne , int numTwo , int numThree)
        {
            int[] numbers = { numOne, numTwo, numThree };
            int num = numbers.Min();
            Console.WriteLine(num);
            
        }
    }
}
