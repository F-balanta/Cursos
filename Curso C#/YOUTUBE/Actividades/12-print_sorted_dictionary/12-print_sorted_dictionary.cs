using System;
using System.Linq;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        foreach (var item in myDict.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

    }
}