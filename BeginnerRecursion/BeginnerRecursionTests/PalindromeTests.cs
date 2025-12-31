using NUnit.Framework;

namespace Structy_CS.BeginnerRecursion;

[TestFixture]
public class PalindromeTests
{
    [TestCase("pop", true)]
    [TestCase("kayak",  true )]
    [TestCase("pops", false)]
    [TestCase("boot", false)]
    [TestCase("rotator", true)]
    [TestCase("abcbca", false)]
    [TestCase("", true)]
    [TestCase("t", true)]
    public static void TestPalindrome(string s, bool expected)
    {
        var result = BeginnerRecursion.Palindrome(s);
        Assert.That(result, Is.EqualTo(expected));
    }
}