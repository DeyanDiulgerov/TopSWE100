using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(input));
        }

        public static int Fib(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            int a = 0, b = 1, c = 1;
            for (int i = 1; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }
    }
}
