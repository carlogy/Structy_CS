
namespace Structy_CS.BeginnerRecursion;

public static partial class BeginnerRecursion 
{
    public static string ReverseString(string s)
    {
        if (s.Length == 0)
        {
            return "";
        }
        return BeginnerRecursion.ReverseString(s.Substring(1, s.Length -1)) + s[0];
    }
}

