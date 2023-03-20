using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FizzBuzz(n));
        }

        public static IList<string> FizzBuzz(int n)
        {
            var list = new List<string>(n);

            int fizz = 0;
            int buzz = 0;

            for (int i = 1; i <= n; i++)
            {
                fizz++;
                buzz++;

                if (fizz == 3 && buzz == 5)
                {
                    list.Add("FizzBuzz");
                    fizz = 0;
                    buzz = 0;
                }
                else if (fizz == 3)
                {
                    list.Add("Fizz");
                    fizz = 0;
                }
                else if (buzz == 5)
                {
                    list.Add("Buzz");
                    buzz = 0;
                }
                else
                {
                    list.Add(i.ToString());
                }
            }


            return list;
        }
    }
}
