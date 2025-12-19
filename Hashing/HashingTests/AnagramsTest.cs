using NUnit.Framework;

namespace Structy_CS.Hashing;

[TestFixture]
public class AnagramsTest
{
    [TestCase("restful", "fluster", true)]
    [TestCase("cats", "tocs", false)]
    [TestCase("monkeyswrite", "newyorktimes", true)]
    [TestCase("paper", "reapa", false)]
    [TestCase("elbow", "below", true)]
    [TestCase("tax", "taxi", false)]
    [TestCase("taxi", "tax", false)]
    [TestCase("night", "thing", true)]
    [TestCase("abbc", "aabc", false)]
    [TestCase("po", "popp", false)]
    [TestCase("pp", "oo", false)]
    public static void TestAnagrams(string s1, string s2, bool expectedResult)
    {
        var result = Hashing.Anagrams(s1, s2);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

}