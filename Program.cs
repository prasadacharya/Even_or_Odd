// Exercise 2
// Input a number (n) from the user and check if it is even or odd.

using System;

namespace Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide your input number");

            string N = Console.ReadLine();

            int n = Convert.ToInt32(N);

            if (n % 2 == 0)

                Console.WriteLine("Number is even");

            else

                Console.WriteLine("Number is odd");
        }
    }
}
