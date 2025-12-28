using NUnit.Framework;

namespace Structy_CS.BeginnerRecursion;

[TestFixture]
public class FactorialTests
{
    [TestCase(3, 6)]
    [TestCase(6, 720)]
    [TestCase(18, 6402373705728000)]
    [TestCase(1, 1)]
    [TestCase(13, 6227020800)]
    [TestCase(0, 1)]
    public static void TestFactorials(int n, long expected)
    {
        var result = BeginnerRecursion.Factorial(n);
        Assert.That(result, Is.EqualTo(expected));
    }
}