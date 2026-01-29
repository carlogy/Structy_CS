using NUnit.Framework;

namespace Structy_CS.LinkedList_1;

[TestFixture]
public class ReverseListTests
{
    [Test]
    public static void Test00Itr()
    {

        var f = new Node<string>("f");
        var e = new Node<string>("e", f);
        var d = new Node<string>("d", e);
        var c = new Node<string>("c", d);
        var b = new Node<string>("b", c);
        var a = new Node<string>("a", b);

        var expected = ConvertToList<string>(a).ToArray().Reverse();
        var reversed = LinkedList1.ReverseListItr<string>(a);
        var result = ConvertToList<string>(reversed!).ToArray();
        Assert.That(expected, Is.EquivalentTo(result));
    }

    [Test]
    public static void Test01Itr()
    {

        var y = new Node<string>("y");
        var x = new Node<string>("x", y);

        var expected = ConvertToList<string>(x).ToArray().Reverse();
        var reversed = LinkedList1.ReverseListItr<string>(x);
        var result = ConvertToList<string>(reversed!).ToArray();
        Assert.That(expected, Is.EquivalentTo(result));
    }

    [Test]
    public static void Test02Itr()
    {
        var p = new Node<string>("p");
        var expected = ConvertToList<string>(p).ToArray();
        var reversed = ConvertToList<string>(p).ToArray();
        Assert.That(expected, Is.EquivalentTo(reversed));
    }

    public static List<T> ConvertToList<T>(Node<T> head)
    {
        var list = new List<T>();
        var current = head;
        while (current != null)
        {
            list.Add(current.Value);
            current = current.Next;
        }
        return list;
    }

}
