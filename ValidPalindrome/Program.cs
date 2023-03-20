using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidPalindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            Console.WriteLine(IsPalindrom(s));

        }

        public static bool IsPalindrom(string s)
        {
            var regex = new Regex("[^a-zA-Z0-9]");

            var reversed = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversed += s[i];
            }

            s = regex.Replace(s, "").ToLower();
            reversed = regex.Replace(reversed, "").ToLower();

            if (reversed == s)
            {
                return true;
            }

            return false;
        }
    }
}
