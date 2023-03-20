using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numberof1Bits
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var input = uint.Parse(Console.ReadLine());
            //var output = uint.Parse(HammingWeight(input).ToString());

            //var stringInput = input.ToString();

            var input = Console.ReadLine();
            //var uintInput = uint.Parse(input);

            Console.WriteLine(HammingWeight(uint.Parse(input)));
            //Console.WriteLine(input);
        }

        public static int HammingWeight(uint n)
        {
            int cnt = 0;

            while (n > 0)
            {
                uint lsd = n & 1; // get the least significant digit
                if (lsd == 1)
                    cnt++;
                n = n >> 1; // right shift n by 1
            }

            return cnt;
        }
    }
}