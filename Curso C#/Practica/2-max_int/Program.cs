using System;
using System.Collections.Generic;
namespace _2_max_int
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {45,21,2,65};
            List<int> list = new List<int>(array);
            int biggest = Max(list);
            Console.WriteLine(biggest);
        }
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count <= 0)
                return 0;
            nums.Sort();
            int max = nums[nums.Count - 1];
            return max;
        }
    }
}
