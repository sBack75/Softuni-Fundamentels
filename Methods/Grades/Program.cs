using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double curCrades = double.Parse(Console.ReadLine());
           
            Console.WriteLine(Grades(curCrades));
        }
        static string Grades(double grades)
        {
            string curGrad = string.Empty;
            if (grades >= 2 && grades <= 2.99 )
            {
                curGrad = "Fail";
                return curGrad;
            }
            else if (grades >= 3 && grades <= 3.49)
            {
                curGrad = "Poor";
                return curGrad;

            }
            else if (grades >= 3.50 && grades <=4.49)
            {
                curGrad = "Good";
                return curGrad;

            }
            else if (grades >= 4.50 && grades <= 5.49)
            {
                curGrad = "Very good";
                return curGrad;

            }
            else if (grades >= 5.50 && grades <= 6)
            {
                curGrad = "Excelent";
                return curGrad;

            }
            return curGrad;

        }
    }
}
