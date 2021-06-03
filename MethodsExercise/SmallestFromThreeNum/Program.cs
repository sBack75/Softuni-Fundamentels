using System;
using System.Linq;

namespace SmallestFromThreeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            password = password.ToLower();
            PasswordValid(password);

        }
        static void PasswordValid(string pass)
        {
            bool passValidator = false;

            if (pass.Length >= 6 && pass.Length <= 10)
            {

            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                passValidator = true;
            }
            char[] symbolCheck = pass.ToCharArray();
            for (int i = 0; i < pass.Length; i++)
            {
                if (symbolCheck[i] < 97 && symbolCheck[i] > 122)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Password must contains only latters of digits" );
                    passValidator = true;
                    break;
                }
            }
            if (symbolCheck[symbolCheck.Length - 1] >= 48 && symbolCheck[symbolCheck.Length - 1] <= 57)
            {
                if (symbolCheck[symbolCheck.Length - 2] >= 48 && symbolCheck[symbolCheck.Length - 2] <= 57)
                {

                }
                else
                {
                    passValidator = true;
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
                passValidator = true;
            }


            // Not finish because need to made that there you must to have only latters or only digits password
            
        }
    }
}
