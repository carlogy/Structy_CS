using NUnit.Framework;

namespace Structy_CS.BeginnerRecursion;

[TestFixture]
public class FibonacciTests
{
    [TestCase(0, 0)]
    [TestCase(1, 1)]
    [TestCase(2, 1)]
    [TestCase(3, 2)]
    [TestCase(4, 3)]
    [TestCase(5, 5)]
    [TestCase(8, 21)]
    [TestCase(25, 75025)]
    public static void TestFibonacci(int n, int expected)
    {
        var result = BeginnerRecursion.Fibonacci(n);
        Assert.That(result, Is.EqualTo(expected));
    }
}