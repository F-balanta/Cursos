using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            int row, col;

           for (row = 0; row < 5; row++)
           {
               for (col = 0; col < 5; col++)
               {
                   array[row, col] = 0;
               }
           }
           array[2, 2] = 1;
           for (row = 0; row < 5; row++)
           {
               for (col = 0; col < 5; col++)
               {
                   Console.Write($"{array[row, col]}");
                   if (col < 5 - 1)
                   {
                       Console.Write(" ");
                   }
               }
                Console.WriteLine();
           }
        }
    }
}
