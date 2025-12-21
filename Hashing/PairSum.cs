using System;
using System.Collections.Generic;

namespace Structy_CS.Hashing;

public static partial class Hashing
{
    public static List<int> PairSum(List<int> arr, int target)
    {
        var pairSum = new List<int>();
        var previous = new Dictionary<int, int>();
        for (var i = 0; i < arr.Count; i++)
        {
            var complement =  target - arr[i];
            if (!previous.ContainsKey(complement))
            {
                previous.Add(arr[i], i);
                continue;
            }
            pairSum.AddRange(previous[complement],i);
            
        }
        return pairSum;
    }
}    