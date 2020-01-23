using System;

namespace Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide your input number");

            string A = Console.ReadLine();

            int a = Convert.ToInt32(A);

            if (a % 2 == 0)

                Console.WriteLine("Number is even");

            else

                Console.WriteLine("Number is odd");
        }
    }
}
