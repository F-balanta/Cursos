using System;

namespace Text
{
    class Str
    {
        static void Main(string[] args)
        {
            int amount = CamelCase("holberton School");
            Console.WriteLine($"{amount}");
        }
        public static int CamelCase(string s)
        {
            int i, cant = 0;
            
            for(i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                cant++;
            }
            return cant;
        }
    }
}
