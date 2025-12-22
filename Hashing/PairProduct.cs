using System;
using System.Collections.Generic;

namespace Structy_CS.Hashing;

public static partial class Hashing
{
    public static List<int> PairProduct(List<int> intList, int target)
    {
        var pairProduct = new List<int>();
        var previous = new Dictionary<double, int>();

        for (var i = 0; i < intList.Count; i++)
        {
            var num = intList[i];
            var complement = (double) target / intList[i];
            if (!previous.ContainsKey(complement))
            {
                previous.Add(intList[i], i);
                continue;
            }
            
            pairProduct.AddRange(previous[complement], i);
            break;
        }
        return pairProduct;
    }
}