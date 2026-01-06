
using NUnit.Framework;

namespace Structy_CS.LinkedList_1;

[TestFixture]
public class LinkedListValuesTests
{
    [Test]
    public static void test_00()
    {
        
        var d = new Node<string>("d", null);
        var c = new Node<string>("c", d);
        var b = new Node<string>("b", c);
        var a = new Node<string>("a", b);
        
        var expected = new List<string>() { "a", "b", "c", "d" };
        var results = LinkedList1.LinkedListValuesItr(a);
        Assert.That(results, Is.EquivalentTo(expected));

        var resultRecursive = LinkedList1.LinkedListValuesRecur(a);
        Assert.That(resultRecursive, Is.EquivalentTo(expected));
    }

    [Test]
    public static void test_01()
    {
        var x = new Node<string>("x");
        var y = new Node<string>("y");
        x.Next = y;

        var expected = new List<string>() { "x", "y" };
        var results = LinkedList1.LinkedListValuesItr(x);
        var resultsRecursive = LinkedList1.LinkedListValuesRecur(x);
        Assert.That(results, Is.EquivalentTo(expected));
        Assert.That(resultsRecursive, Is.EquivalentTo(expected));

    }

    [Test]
    public static void test_02()
    {
        var q = new Node<string>("q");
        var expected = new List<string>(){"q"};
        var results = LinkedList1.LinkedListValuesItr(q);
        var resultsRecursive = LinkedList1.LinkedListValuesRecur(q);
        Assert.That(results, Is.EquivalentTo(expected));
        Assert.That(resultsRecursive, Is.EquivalentTo(expected));
    }
    
}


