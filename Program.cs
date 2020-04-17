using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        public static int Fact(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            return number * Fact(number - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value to calculate Factorial");
            Console.WriteLine(Fact(Convert.ToInt32(Console.ReadLine())));
            Console.ReadLine();
        }
    }
}
