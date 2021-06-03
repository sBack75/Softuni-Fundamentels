using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            passValidator(password);

        }
        static void passValidator(string password)
        {
            char[] pass = new char [password.Length];
            int digit = 0;
            int symbols = 0;
            int letters = 0;
 
            for (int i = 0; i < password.Length; i++)
            {
                pass[i] = password[i];
            }
            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] >= 48 && pass[i] <=57)
                {
                    digit++;

                }
                else if (pass[i] >= 32 && pass[i] <=47 || pass[i] >=58 && pass[i]<=64 || pass[i]>=91 && pass[i] <=96 || pass[i] >= 123 && pass[i]<=136)
                {
                    symbols++; 
                }
                else if (pass[i] >=65 && pass[i] <=90 || pass[i] >= 97 && pass[i] <=122)
                {
                    letters++;
                }
            }
            int total = letters + digit + symbols;
            if (total<6 || total>10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (symbols>=1)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (digit < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            else
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
