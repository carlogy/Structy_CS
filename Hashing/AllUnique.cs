
namespace Structy_CS.Hashing;

public static partial class Hashing
{
    public static bool AllUnique<T>(List<T> list)
    {
        var hashList = new HashSet<T>(list);
        return list.Count() == hashList.Count();
    }
}