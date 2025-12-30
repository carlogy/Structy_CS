using NUnit.Framework;

namespace Structy_CS.BeginnerRecursion;

[TestFixture]
public class ReverseStringsTests
{
    [TestCase("hello", "olleh")]
    [TestCase("abcdefg", "gfedcba")]
    [TestCase("stopwatch", "hctawpots")]
    [TestCase("", "")]
    public static void TestReverseStrings(string s, string expected)
    {
        var result = BeginnerRecursion.ReverseString(s);
        Assert.That(result, Is.EqualTo(expected));
    }
}