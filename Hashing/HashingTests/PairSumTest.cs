using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Structy_CS.Hashing;

[TestFixture]
public class PairSumTest
{
    [TestCase(new[] { 3, 2, 5, 4, 1 }, 8, new[] { 0, 2 })]
    [TestCase(new[] { 4, 7, 9, 2, 5, 1 }, 5, new[] { 0, 5 })]
    [TestCase(new[] { 4, 7, 9, 2, 5, 1 }, 3, new[] { 3, 5 })]
    [TestCase(new[] { 1, 6, 7, 2 }, 13, new[] { 1, 2 })]
    [TestCase(new[] { 9, 9 }, 18, new[] { 0, 1 })]
    [TestCase(new[] { 6, 4, 2, 8 }, 12, new[] { 1, 3 })]
    public void TesPairSum(int[] intList, int target, int[] expected)
    {
        var result = Hashing.PairSum(intList.ToList(), target);
        Assert.That(result, Is.EqualTo(expected.ToList()));
    }

    [Test]
    public void TestLargeArrPairSum()
    {
        var intList = new List<int>();
        for (int i = 1; i <= 25000; i++)
        {
            intList.Add(i);
        }
        var result = Hashing.PairSum(intList,49999 );
        var expected = new List<int>(){24998, 24999 };
        Assert.That(result, Is.EqualTo(expected));
    }

}