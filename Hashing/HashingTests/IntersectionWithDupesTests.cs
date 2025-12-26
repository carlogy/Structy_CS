using NUnit.Framework;

namespace Structy_CS.Hashing;

[TestFixture]
public class IntersectionWithDupesTests
{
    [TestCase(new[]{"a", "b", "c", "b"}, new[]{"x", "y", "b", "b"}, new[]{"b", "b"})]
    [TestCase(new[]{"q", "b", "m", "s", "s", "s"}, new[]{"s", "m", "s"}, new[]{"m", "s", "s"})]
    [TestCase(new[]{"p", "r", "r", "r"}, new[]{"r"}, new[]{"r"})]
    [TestCase(new[]{"r"}, new[]{"p", "r", "r", "r"}, new[]{"r"})]
    [TestCase(new[]{"t", "v", "u"}, new[]{"g", "e", "d", "f"}, new string[]{})]
    [TestCase(new[]{"a", "a", "a", "a", "a", "a"}, new[]{"a", "a", "a", "a"}, new[]{"a", "a", "a", "a"})]
    public static void TestIntersectionWithDupes(string[] a, string[] b, string[] expected)
    {
        var actual = Hashing.IntersectionWithDupes(a.ToList(), b.ToList());
        Assert.That(actual, Is.EquivalentTo(expected.ToList()));
    }

    [Test]
    public static void TestIntersectionWithDupesLargeList()
    {
        var a = new List<int>();
        var b = new List<int>();
        var expected = new List<int>();

        for (var i = 0; i < 200000; i++)
        {
            a.Add(i);
            b.Add(i);
            expected.Add(i);
        }
        
        var result = Hashing.IntersectionWithDupes(a, b);
        Assert.That(result, Is.EquivalentTo(expected));
    }
}