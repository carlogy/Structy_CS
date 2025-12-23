using NUnit.Framework;

namespace Structy_CS.Hashing;

[TestFixture]
public class IntersectionTests
{
    [TestCase(new[]{4,2,1,6}, new[]{3,6,9,2,10}, new[]{2,6})]
    [TestCase(new[]{2,4,6}, new[]{4,2}, new[]{2,4})]
    [TestCase(new[]{4,2,1}, new[]{1,2,4,6}, new[]{1,2,4})]
    [TestCase(new[]{0,1,2}, new[]{10,11}, new int[]{})]
    public void TestIntersection(int[] a, int[] b, int[] expected)
    {
        var result = Hashing.Intersection(a.ToList(), b.ToList());
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
            expected.Add(i);
        }

        var result = Hashing.Intersection(a, b);
        Assert.That(result, Is.EquivalentTo(expected));

    }
}