
namespace Structy_CS.BeginnerRecursion;

public static partial class BeginnerRecursion
{
    public static long Factorial(int n)
    {

        if (n == 0  ||  n == 1)
        {
            return 1;
        }
        
        return n * Factorial(n - 1);
    }
}

