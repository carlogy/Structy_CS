using NUnit.Framework;

namespace Structy_CS.Intro;

[TestFixture]
public class LongestWordTest
{
    [Test]
    public void WhatAWonderfulWorld()
    {
        var sentence = "what a wonderful world";
        var result = Intro.LongestWord(sentence);
        var expected = "wonderful";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void HaveANiceday()
    {
        var sentence = "have a nice day";
        var result = Intro.LongestWord(sentence);
        var expected = "nice";
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void TheQuickBrownFoxJumpedOverTheLazyDog()
    {
        var sentence = "the quick brown fox jumped over the lazy dog";
        var result = Intro.LongestWord(sentence);
        var expected = "jumped";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void WhoDidEatTheHam()
    {
        var sentence = "who did eat the ham";
        var result = Intro.LongestWord(sentence);
        var expected = "ham";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Potato()
    {
        var sentence = "potato";
        var result = Intro.LongestWord(sentence);   
        var expected = "potato";
        Assert.That(result, Is.EqualTo(expected));
    }
}