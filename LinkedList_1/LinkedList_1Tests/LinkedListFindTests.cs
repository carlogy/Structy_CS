using NUnit.Framework;

namespace Structy_CS.LinkedList_1;

[TestFixture]
public class LinkedListFindTests
{
    [Test]
    public static void Test_00_Itr()
    {
        var d = new Node<string>("d");
        var c = new Node<string>("c", d);
        var b = new Node<string>("b", c);
        var a = new Node<string>("a", b);

        var expected = true;
        var resultItr = LinkedList1.LinkedListFindItr(a, "c");
        Assert.That(resultItr, Is.EqualTo(expected));
    }

    [Test]
    public static void Test_01_Itr()
    {
        var d = new Node<string>("d");
        var c = new Node<string>("c", d);
        var b = new Node<string>("b", c);
        var a = new Node<string>("a", b);

        var expected = true;
        var resultItr = LinkedList1.LinkedListFindItr(a, "d");
        Assert.That(resultItr, Is.EqualTo(expected));
    }

    [Test]
    public static void Test_02_Itr()
    {
        var d = new Node<string>("d");
        var c = new Node<string>("c", d);
        var b = new Node<string>("b", c);
        var a = new Node<string>("a", b);

        var expected = false;
        var resultItr = LinkedList1.LinkedListFindItr(a, "q");
        Assert.That(resultItr, Is.EqualTo(expected));
    }

    [Test]
    public static void Test_03_Itr()
    {
        var node2 = new Node<string>("leneli");
        var node1 = new Node<string>("jason", node2);
        var expected = true;
        var resultItr = LinkedList1.LinkedListFindItr(node1, "jason");
        Assert.That(resultItr, Is.EqualTo(expected));
    }

    [Test]
    public static void Test_04_Itr()
    {
        var node1 = new Node<int>(42);
        var expected = false;
        var resultItr = LinkedList1.LinkedListFindItr(node1, 2);
        Assert.That(resultItr, Is.EqualTo(expected));
    }
}