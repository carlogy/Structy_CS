
namespace  Structy_CS.BeginnerRecursion;

public static partial class BeginnerRecursion
{
    public static void Countdown(int n)
    {
        if (n == 0)
        {
            return;
        }
        
        Console.WriteLine(n);
        Countdown(n-1);
    }
}



