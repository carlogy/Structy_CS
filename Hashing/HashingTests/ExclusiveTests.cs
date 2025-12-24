using NUnit.Framework;

namespace Structy_CS.Hashing;

[TestFixture]
public class ExclusiveTests
{
    [TestCase(new[]{4,2,1,6}, new[]{3,6,9,2,10}, new[]{4,1,3,9,10})]
    [TestCase(new[]{2,4,6}, new[]{4,2}, new[]{6})]
    [TestCase(new[]{4,2,1}, new[]{1,2,4,6}, new[]{6})]
    [TestCase(new[]{0,1,2}, new[]{10,11}, new[]{0,1,2,10,11})]
    public void TestExclusiveItems(int[] a, int[] b, int[] expected)
    {
        var result = Hashing.ExclusiveItems(a.ToList(), b.ToList());
        Assert.That(result, Is.EquivalentTo(expected.ToList()));
    }
    
    [Test]
    public void TestLargeList()
    {
        var a = new List<int>();
        var b = new List<int>();
        var expected = new List<int>();

        for (var i = 0; i < 60000; i++)
        {
            a.Add(i);
            b.Add(i);
        }

        var result = Hashing.ExclusiveItems(a, b);
        Assert.That(result, Is.EquivalentTo(expected));

    }
}