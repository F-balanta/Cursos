using System.Text.RegularExpressions;
using System;

namespace _3_palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Ad .a";
            var cadena = IsPalindrome(s);
            Console.WriteLine(cadena);
        }
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 0)
                return true;
            string reverse;
            reverse = String.Empty;
            foreach (char characters in s)
            {
                reverse = characters + reverse;
            }
            reverse = Regex.Replace(reverse, @"[^\w]");
            s = Regex.Replace(s, @"[^\w]", "");
            Console.WriteLine("R// " + s);
            Console.WriteLine("D// " + reverse);
            if (s.ToUpper() == reverse.ToUpper())
                return true;
            return false;

        }
    }
}
