using System;


class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index < 0 || index >= array.Length)
        {
            Console.Write("Index out of range\n");
            return array;
        }
        array[index] = n;
        return array;
    }
}

