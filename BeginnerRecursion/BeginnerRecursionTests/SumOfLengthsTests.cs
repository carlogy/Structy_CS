using NUnit.Framework;

namespace Structy_CS.BeginnerRecursion;

[TestFixture]
public class SumOfLengthsTests
{
    [TestCase(new[] { "goat", "cat", "purple" }, 13)]
    [TestCase(new[]{"bike", "at", "pencils", "phone"}, 18)]
    [TestCase(new string[]{}, 0)]
    [TestCase(new[]{"", " ", "  ", "   ", "    ", "     "}, 15)]
    [TestCase(new[]{"0", "313", "1234567890"}, 14)]
    public static void TestSumOfLengths(string[] words, int expected)
    {
        var result = BeginnerRecursion.SumOfLengths(words.ToList());
        Assert.That(result, Is.EqualTo(expected));
    }
}