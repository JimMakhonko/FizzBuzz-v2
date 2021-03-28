using System;

namespace FizzBuzzV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number lolka: ");
            NewMethod(Convert.ToInt32(Console.ReadLine()));
        }

        private static int NewMethod(int a)
        {
            if (a % 15 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (a % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (a % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            return a;
        }
    }
}
