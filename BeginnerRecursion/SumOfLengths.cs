
namespace Structy_CS.BeginnerRecursion;

public static partial class BeginnerRecursion
{
    public static int SumOfLengths(List<string> words)
    {
        var sum = 0;
        if (words.Count == 0)
        {
            return sum;
        }
        
        return words[0].Length + SumOfLengths(words.Slice(1, words.Count - 1));
    }
}