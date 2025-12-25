using NUnit.Framework;

namespace Structy_CS.Hashing;

[TestFixture]
public class AllUniqueTests
{
    [TestCase(new[]{"q", "r", "s", "a"}, true)]
    [TestCase(new[]{"q", "r", "s", "a", "r", "z"}, false)]
    [TestCase(new[]{"red", "blue", "yellow", "green", "orange"}, true)]
    [TestCase(new[]{"cat", "cat", "dog"}, false)]
    public static void TestAllUnique(string[] list, bool expected)
    {
        var result = Hashing.AllUnique(list.ToList());
        Assert.That(result, Is.EqualTo(expected));
    }
}