using NUnit.Framework;

namespace Structy_CS.BeginnerRecursion;

[TestFixture]
public class SumNumberRecursiveTests
{
    [TestCase(new[] { 5, 2, 9, 10 }, 26)]
    [TestCase(new[]{1, -1, 1, -1, 1, -1, 1},  1)]
    [TestCase(new int[]{}, 0)]
    [TestCase(new []{1000, 0, 0, 0, 0, 0, 1}, 1001)]
    [TestCase(new [] {700, 70, 7}, 777)]
    [TestCase(new []{-10, -9, -8, -7, -6, -5, -4, -3, -2, -1}, -55)]
    [TestCase(new []{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, 0)]
    [TestCase(new []{123456789, 12345678, 1234567, 123456, 12345, 1234, 123, 12, 1, 0}, 137174205)]
    public void TestSumNumberRecursive(int[] list, int expected)
    {
        var result = BeginnerRecursion.SumNumbersRecursive(list.ToList());
        Assert.That(result, Is.EqualTo(expected));
    }
}

