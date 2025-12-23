
namespace Structy_CS.Hashing;

public static partial class Hashing
{
    public static List<T> Intersection<T>(List<T> a, List<T> b) where T : notnull
    {
        var list = new List<T>();
        var hashA = new HashSet<T>(a);
        
        foreach (var item in b)
        {
            if (hashA.Contains(item))
            {
                list.Add(item);
            }
        }
        return list;
    }
}