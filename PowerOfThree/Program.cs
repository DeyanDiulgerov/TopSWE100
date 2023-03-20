using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfThree
{
    public class Program
    {
        static void Main(string[] args)
        {
        }


        public static bool IsPowerOfThree(int n)
        {
            if (n < 1)
                return false;

            while (n > 1)
            {
                if (n % 3 != 0)
                {
                    return false;
                }
                n /= 3;
            }

            return true;
        }
    }
}
