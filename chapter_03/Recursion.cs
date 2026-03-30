using System;

namespace Algorithms.Chapter03
{
    class RecursionProgram
    {
        public static int Factorial(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                Console.WriteLine($"Returning {x} * factorial({x - 1})");
                return x * Factorial(x - 1);
            }
        }

        public static void Main()
        {
            Console.WriteLine(Factorial(5));
        }
    }
}
