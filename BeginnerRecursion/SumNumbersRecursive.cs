
namespace Structy_CS.BeginnerRecursion;

public static partial class BeginnerRecursion
{
    public static int SumNumbersRecursive(List<int> ints)
    {
        var total = 0;
        if (ints.Count == 0)
        {
            return total;
        }
        return ints[0] + SumNumbersRecursive(ints.GetRange(1, ints.Count - 1));
    }
}

