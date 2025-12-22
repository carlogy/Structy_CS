using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Structy_CS.Hashing;

[TestFixture]
public class PairProductTest
{

    [TestCase(new[] { 3, 2, 5, 4, 1 }, 8, new[] { 1, 3 })]
    [TestCase(new [] {3, 2, 5, 4, 1}, 10,new[]{1, 2})]
    [TestCase(new []{4, 7, 9, 2, 5, 1}, 5, new []{4,5})]
    [TestCase(new []{4, 7, 9, 2, 5, 1}, 35,new []{1,4})]
    [TestCase(new []{3, 2, 5, 4, 1}, 10, new[]{1, 2})]
    [TestCase(new []{4, 6, 8, 2}, 16, new[]{2,3})]
    public void PairProductTests(int[] intList, int target, int[] expected)
    {
        var result = Hashing.PairProduct(intList.ToList(), target);
        Assert.That(result, Is.EqualTo(expected.ToList()));
    }
    
    [Test]
    public void TestLargeArrPairProduct()
    {
        var intList = new List<int>();
        for (int i = 1; i <= 25000; i++)
        {
            intList.Add(i);
        }
        var result = Hashing.PairProduct(intList,624975000 );
        var expected = new List<int>(){ 24998, 24999 };
        Assert.That(result, Is.EqualTo(expected));
    }
}