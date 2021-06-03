using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            matrix(matrixSize);

        }
        static void matrix(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int s = 0; s < size; s++)
                {
                    Console.Write($"{size + " "}");
                }
                Console.WriteLine();
            }
        }
    }
}
