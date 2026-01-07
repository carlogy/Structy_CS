using NUnit.Framework;

namespace Structy_CS.LinkedList_1;

[TestFixture]
public class SumListTests
{
    
    [Test]
    public static void Test_00()
    {
        var a = new Node<int>(2);
        var b = new Node<int>(8);
        var c = new Node<int>(3);
        var d = new Node<int>(-1);
        var e = new Node<int>(7);
    
        a.Next = b; 
        b.Next = c;
        c.Next = d;
        d.Next = e;

        var expected = 19;
        var resulsItr = LinkedList1.SumListItr(a);
        Assert.That(resulsItr, Is.EqualTo(expected));

    }

    [Test]
    public static void Test_01()
    {
        var x = new Node<int>(38);
        var y = new Node<int>(4);
        x.Next = y;

        var expected = 42;
        var resultItr = LinkedList1.SumListItr(x);
        Assert.That(resultItr, Is.EqualTo(expected));
    }

    [Test]
    public static void Test_02()
    {
        var z = new Node<int>(100);
        
        var expected = 100;
        var resultItr = LinkedList1.SumListItr(z);
        Assert.That(resultItr, Is.EqualTo(expected));
    }

    [Test]
    public static void Test_00_recur()
    {
        var a = new Node<int>(2);
        var b = new Node<int>(8);
        var c = new Node<int>(3);
        var d = new Node<int>(-1);
        var e = new Node<int>(7);
    
        a.Next = b; 
        b.Next = c;
        c.Next = d;
        d.Next = e;

        var expected = 19;
        var resultRecur = LinkedList1.SumListRecur(a);
        Assert.That(resultRecur, Is.EqualTo(expected));
    }

    [Test]
    public static void Test_01_Recur()
    {
        var x = new Node<int>(38);
        var y = new Node<int>(4);
        x.Next = y;

        var expected = 42;
        var resultRecur = LinkedList1.SumListRecur(x);
        Assert.That(resultRecur, Is.EqualTo(expected));
    }

    [Test]
    public static void Test_02_Recur()
    {
        var z = new Node<int>(100);
        var expected = 100;
        var resultRecur = LinkedList1.SumListRecur(z);
        Assert.That(resultRecur, Is.EqualTo(expected));
    }
}