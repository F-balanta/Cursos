using System.Runtime.Serialization;
using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] JaggedArray = new int[3][]{
                new int[] { 0, 1, 2, 3},
                new int[] { 0, 1, 2, 3, 4, 5, 6},
                new int[] {0, 1}
            };
            for(int i = 0; i < JaggedArray.Length; i++){
                for(int j = 0; j < JaggedArray[i].Length; j++){
                    Console.Write($"{JaggedArray[i][j]}");
                    if (j < JaggedArray[i].Length - 1)Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
    }
