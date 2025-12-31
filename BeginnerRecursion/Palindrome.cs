
namespace Structy_CS.BeginnerRecursion;

public static partial class BeginnerRecursion
{
    public static bool Palindrome(string s)
    {
        if (s.Length <= 1)
        {
            return true;
        } 
        if  (s[0] != s[^1])
        {
            return false;
        }
        
        return Palindrome(s[1..^1]);
    }

}

