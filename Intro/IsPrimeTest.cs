using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;

namespace Structy_CS.Intro;

[TestFixture]
public class IsPrimeTest
{   
    [TestCase(1, false)]
    [TestCase(2, true)]
    [TestCase(3, true)]
    [TestCase(4, false)]
    [TestCase(5, true)]
    [TestCase(6, false)]
    [TestCase(7, true)]
    [TestCase(8, false)]
    [TestCase(25, false)]
    [TestCase(31, true)]
    [TestCase(713, false)]
    [TestCase(2017, true)]
    [TestCase(2048, false)]
    public void IsPrimeTesting(int num, bool expected)
    {
        Assert.That(Intro.IsPrime(num), Is.EqualTo(expected));
    }
}