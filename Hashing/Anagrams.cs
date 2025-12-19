using System.Collections.Generic;

namespace Structy_CS.Hashing;

public static partial class Hashing
{
    public static bool Anagrams(string s1, string s2)
    {
        var chars = new Dictionary<char, int>();
        foreach (var c in s1)
        {
            if (!chars.ContainsKey(c))
            {
                chars.Add(c, 0);
            }
            chars[c]++;
        }

        foreach (var c in s2)
        {
            if (!chars.ContainsKey(c))
            {
                return false;
            }
            chars[c]--;
        }
        
        foreach (var c in chars) {
            if (c.Value != 0)
            {
                return false;
            }
        }

        return true;
    }
}