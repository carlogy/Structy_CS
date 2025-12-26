
namespace  Structy_CS.Hashing;

public static partial class Hashing
{
    public static List<T> IntersectionWithDupes<T>(List<T> a, List<T> b) where T: notnull
    {
        var interWithDupes = new List<T>();
        var hashA = ConvertToDictHelper(a);
        var hashB = ConvertToDictHelper(b);
        
        foreach (var item in hashA.Keys)
        {
            if (hashB.ContainsKey(item))
            {
                var minCount = Math.Min(hashA[item], hashB[item]);
                for (var i = 0; i < minCount; i++)
                {
                    interWithDupes.Add(item);
                }
            }
        }
        
        return interWithDupes;
    }    
    
    public static Dictionary<T, int> ConvertToDictHelper<T>(List<T> list) where T : notnull
    {
        var hashList = new Dictionary<T, int>();
        foreach (var item in list)
        {
            if (!hashList.TryGetValue(item, out _))
            {
                hashList.Add(item, 0);
            }
            hashList[item]++;
        }
        return hashList;
    }
}


