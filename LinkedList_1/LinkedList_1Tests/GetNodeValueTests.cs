using NUnit.Framework;

namespace Structy_CS.LinkedList_1;

[TestFixture]
public class GetNodeValueTests
{
    [Test]
    public static void Test_00_Itr()
    {
        var d = new Node<string>("d");
        var c = new Node<string>("c", d);
        var b = new Node<string>("b", c);
        var a = new Node<string>("a", b);
        var expected = "c";
        var resultItr = LinkedList1.GetNodeValueItr(a, 2);
        Assert.That(resultItr, Is.EqualTo(expected));
    }
    
    [Test]
    public static void Test_01_Itr()
    {
        var d = new Node<string>("d");
        var c = new Node<string>("c", d);
        var b = new Node<string>("b", c);
        var a = new Node<string>("a", b);
        var expected = "d";
        var resultItr = LinkedList1.GetNodeValueItr(a, 3);
        Assert.That(resultItr, Is.EqualTo(expected));
    }
    
    [Test]
    public static void Test_02_Itr()
    {
        var d = new Node<string>("d");
        var c = new Node<string>("c", d);
        var b = new Node<string>("b", c);
        var a = new Node<string>("a", b);
        var expected = default(string);
        var resultItr = LinkedList1.GetNodeValueItr(a, 7);
        Assert.That(resultItr, Is.EqualTo(expected));
    }

    [Test]
    public static void Test_03_Itr()
    {
        var node2 = new Node<string>("mango");
        var node1 = new Node<string>("banana", node2);
        var expected = "banana";
        var resultItr = LinkedList1.GetNodeValueItr(node1, 0);
        Assert.That(resultItr, Is.EqualTo(expected));
    }
    
    [Test]
    public static void Test_04_Itr()
    {
        var node2 = new Node<string>("mango");
        var node1 = new Node<string>("banana", node2);
        var expected = "mango";
        var resultItr = LinkedList1.GetNodeValueItr(node1, 1);
        Assert.That(resultItr, Is.EqualTo(expected));
    }
    
    [Test]
    public static void Test_00_Recur()
    {
        var d = new Node<string>("d");
        var c = new Node<string>("c", d);
        var b = new Node<string>("b", c);
        var a = new Node<string>("a", b);
        var expected = "c";
        var resultItr = LinkedList1.GetNodeValueRecur(a, 2);
        Assert.That(resultItr, Is.EqualTo(expected));
    }
    
    [Test]
    public static void Test_01_Recur()
    {
        var d = new Node<string>("d");
        var c = new Node<string>("c", d);
        var b = new Node<string>("b", c);
        var a = new Node<string>("a", b);
        var expected = "d";
        var resultItr = LinkedList1.GetNodeValueRecur(a, 3);
        Assert.That(resultItr, Is.EqualTo(expected));
    }
    
    [Test]
    public static void Test_02_Recur()
    {
        var d = new Node<string>("d");
        var c = new Node<string>("c", d);
        var b = new Node<string>("b", c);
        var a = new Node<string>("a", b);
        var expected = default(string);
        var resultItr = LinkedList1.GetNodeValueRecur(a, 7);
        Assert.That(resultItr, Is.EqualTo(expected));
    }
    
    [Test]
    public static void Test_03_Recur()
    {
        var node2 = new Node<string>("mango");
        var node1 = new Node<string>("banana", node2);
        var expected = "banana";
        var resultItr = LinkedList1.GetNodeValueRecur(node1, 0);
        Assert.That(resultItr, Is.EqualTo(expected));
    }
    
    [Test]
    public static void Test_04_Recur()
    {
        var node2 = new Node<string>("mango");
        var node1 = new Node<string>("banana", node2);
        var expected = "mango";
        var resultItr = LinkedList1.GetNodeValueRecur(node1, 1);
        Assert.That(resultItr, Is.EqualTo(expected));
    }
}