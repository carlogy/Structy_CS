using System.Collections.Generic;
using NUnit.Framework;

namespace Structy_CS.Intro;

[TestFixture]
public class FizzBuzzTest
{
    [Test]
    public void TestFizzBuzz11()
    {
        var expected = new List<object>(){1,2,"fizz",4,"buzz","fizz",7,8,"fizz","buzz",11};
        var result = Intro.FizzBuzz(11);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestFizzBuzz2()
    {
        var expected = new List<object>() { 1, 2 };
        var result = Intro.FizzBuzz(2);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestFizzBuzz16()
    {
        var expected = new List<object>() {1,2,"fizz",4,"buzz","fizz",7,8,"fizz","buzz",11, "fizz", 13, 14, "fizzbuzz", 16};
        var result = Intro.FizzBuzz(16);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestFizzBuzz32()
    {
        var expected = new List<object>()
        {
          1, 2, "fizz", 4, "buzz", "fizz", 7, 8, "fizz", "buzz", 11, "fizz", 13, 14, "fizzbuzz", 16, 17, "fizz", 19, "buzz", "fizz", 22, 23, "fizz", "buzz", 26, "fizz", 28, 29, "fizzbuzz", 31, 32 };
        var result = Intro.FizzBuzz(32);
        Assert.That(result, Is.EqualTo(expected));
    }

}