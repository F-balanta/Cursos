using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> nlist = new List<bool>();

        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] % 2 == 0)
                nlist.Add(true);
            else
                nlist.Add(false);
        }
        return nlist;
    }
}
