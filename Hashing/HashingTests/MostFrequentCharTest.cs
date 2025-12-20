using NUnit.Framework;

namespace Structy_CS.Hashing;

[TestFixture]
public class MostFrequentCharTest
{
    [TestCase("bookeeper",  'e')]
    [TestCase("david",  'd')]
    [TestCase("abby", 'b')]
    [TestCase("mississippi", 'i')]
    [TestCase("potato", 'o')]
    [TestCase("eleventennine", 'e')]
    [TestCase("riverbed", 'r')]
    public static void TestAnagrams(string s1,  char expectedResult)
    {
        var result = Hashing.MostFrequentChar(s1);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

}