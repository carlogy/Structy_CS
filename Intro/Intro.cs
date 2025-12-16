using System;

namespace Structy_CS.Intro;

public static class Intro
{

    public static double MaxValue(double[] nums)
    {
        var max = double.MinValue;

        foreach (var num in nums) 
        {
            if (num >= max)
            {
                max = num;
            }
        }
        return max;
    }

    public static string LongestWord(string sentence)
    {
        var words = sentence.Split(' ');
        var longest = "";
        foreach (var word in words)
        {
            if (word.Length >= longest.Length)
            {
                longest = word;
            }
        }
        return longest;
    }

    public static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        
        for (var i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}