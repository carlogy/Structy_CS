using NUnit.Framework;

namespace Structy_CS.Intro;

[TestFixture]
public class MaxValueTest
{
    [Test]
    public void MaxValue10()
    {
        var nums = new double[]{4, 7, 2, 8, 10, 9 };
        var result = Intro.MaxValue(nums);
        var expected = (double) 10;
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void MaxValue40Point3() {
        var nums = new double[]{10, 5, 40, 40.3 };
        var result = Intro.MaxValue(nums);
        var expected =  40.3;
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void MaxValueNegative1()
    {
        var nums = new double[] { -5, -2, -1, -11 };
        var result = Intro.MaxValue(nums);
        var expected = (double) -1;
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void MaxValue42()
    {
        var nums = new double[] { 42 };
        var result = Intro.MaxValue(nums);
        var expected = (double) 42;
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void MaxValueNegative1000()
    {
        var nums = new double[] { 1000, 8 };
        var result = Intro.MaxValue(nums);
        var expected = (double) 1000;
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void MaxValue9000()
    {
        var nums = new double[] { 1000, 8, 9000 };
        var result = Intro.MaxValue(nums);
        var expected = (double) 9000;
        Assert.That(result, Is.EqualTo(expected));
    }
}