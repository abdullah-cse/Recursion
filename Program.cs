using System;

namespace Recursion
{
    class Program
    {
         static int Fact(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            return number * Fact(number - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial Calculation");
            Console.WriteLine("Enter a value to calculate Factorial");
            Console.WriteLine(Fact(Convert.ToInt32(Console.ReadLine())));
            Console.ReadLine();
        }
    }
}
