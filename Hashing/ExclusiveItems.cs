
namespace Structy_CS.Hashing;

public static partial class Hashing
{
    public static List<T> ExclusiveItems<T>(List<T> a, List<T> b) where T : notnull
    {
        var result = new HashSet<T>();
        var hashA = new HashSet<T>(a);
        var hashB = new HashSet<T>(b);
        
        foreach (var item in hashB)
        {
            if (!hashA.Contains(item))
            {
                result.Add(item);
            }
        }

        foreach (var item in hashA)
        {
            if (!hashB.Contains(item))
            {
                result.Add(item);
            }
        }
        
        return result.ToList();
    }
}
