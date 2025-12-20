using System;
using System.Collections.Generic;

namespace Structy_CS.Hashing;

public static partial class Hashing
{
    public static Dictionary<char, int> getDictCount(string str)
    {
        var dict = new Dictionary<char, int>();
        foreach (var ch in str)
        {
            if (!dict.ContainsKey(ch))
            {
                dict[ch] = 0;
            }
            dict[ch]++;
        }
        return dict;
    }

    public static char MostFrequentChar(string s)
    {
        
        var charCount = getDictCount(s);
        var mostFrequentChar = '\0';
        
        foreach (var ch in s)
        {
            if (mostFrequentChar == '\0' || charCount[ch] > charCount[mostFrequentChar])
            {
                mostFrequentChar = ch;
            }
        }
        return mostFrequentChar;
    }
}