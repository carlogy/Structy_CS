using System.Collections.Generic;
using NUnit.Framework;

namespace Structy_CS.Intro;

[TestFixture]
public class PairsTest
{
    [Test]
    public void PairsTestABC()
    {
        var expected = new List<List<string>>()
        {
            new List<string>() { "a", "b"},
            new List<string>() { "a", "c"},
            new List<string>() { "b", "c"}
        };
        var result = Intro.Pairs(new List<string>() { "a", "b", "c" });
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void PairsTestABCD()
    {
        var expected = new List<List<string>>()
        {
            new List<string>() { "a", "b"},
            new List<string>() { "a", "c"},
            new List<string>() { "a", "d"},
            new List<string>() { "b", "c"},
            new List<string>() { "b", "d"},
            new List<string>() { "c", "d"}
        };
        var result = Intro.Pairs(new List<string>() { "a", "b", "c", "d" });
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void PairsTestFruits()
    {
        var expected = new List<List<string>>()
        {
            new List<string>() { "cherry", "cranberry"},
            new List<string>() { "cherry", "banana"},
            new List<string>() { "cherry", "blueberry"},
            new List<string>() { "cherry", "lime"},
            new List<string>() { "cherry", "papaya"},
            new List<string>() { "cranberry", "banana"},
            new List<string>() { "cranberry", "blueberry"},
            new List<string>() { "cranberry", "lime"},
            new List<string>() { "cranberry", "papaya"},
            new List<string>() { "banana", "blueberry"},
            new List<string>() { "banana", "lime"},
            new List<string>() { "banana", "papaya"},
            new List<string>() { "blueberry", "lime"},
            new List<string>() { "blueberry", "papaya"},
            new List<string>() { "lime", "papaya"},
        };
        var result = Intro.Pairs(new List<string>() { "cherry", "cranberry", "banana", "blueberry", "lime", "papaya" });
        Assert.That(result, Is.EqualTo(expected));
    }
}