using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.Write("Size cannot be negative");
            return null;
        }
        var array = new int[size];
        if (size  == 0)
            Console.Write("\n");
        for (int i = 0; i < size -1; i++)
        {
            array[i] = i;
            Console.Write(array[i]);
            if (i < size - 1)
                Console.Write(" ");
        }
        Console.Write("\n");
        return array;
    }
}