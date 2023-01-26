using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> nlist = new List<int>();

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        for (int i = 0; i < size; i++)
        {
            nlist.Add(i);
            Console.Write(nlist[i]);
            if (i < size - 1)
                Console.Write(" ");
        }
        Console.Write("\n");
        return nlist;
    }
}