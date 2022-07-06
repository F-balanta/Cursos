using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        var BestScoreDict = from x in myList orderby x.Value ascending select x.Key;
        return BestScoreDict.ElementAt(BestScoreDict.Count() - 1);
    }

}