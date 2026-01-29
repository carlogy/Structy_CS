
namespace Structy_CS.LinkedList_1;

public static partial class LinkedList1
{
    public static Node<T>? ReverseListItr<T>(Node<T>? head)
    {
        var current = head;
        Node<T>? prev = null;
        while (current != null)
        {
            var next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }
        return prev;
    }
}
