using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers would you like to know from the Fibonacci Sequence?");
            Console.WriteLine();
            int n = Convert.ToInt32(Console.ReadLine());
            int first = 0;
            int prev = 0;
            Console.WriteLine();

            for (int i = 0; i <= n-1; i++)
            {
                Console.WriteLine(first);

                if (first == 0)
                {
                    first = 1;

                }

                else
                {
                    int second = first;
                    first = first + prev;
                    prev = second;

                }

            }
            Console.ReadLine();
        }
    }
}
