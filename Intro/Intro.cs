namespace Structy_CS.Intro;

public static partial class Intro
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

    public static List<object> FizzBuzz(int num)
    {
        var list = new List<object>();
        for (var i = 1; i <= num; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                list.Add("fizzbuzz");
               
            } else if (i % 5 == 0)
            {
                list.Add("buzz");
               
            } else if (i % 3 == 0)
            {
                list.Add("fizz");
            }
            else
            {
                list.Add(i);
            }
        }
        return list;
    }
}