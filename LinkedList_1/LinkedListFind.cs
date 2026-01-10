
namespace Structy_CS.LinkedList_1;

public static partial class LinkedList1
{
    public static bool LinkedListFindItr<T>(Node<T> head, T target)
    {
        var current = head;

        while (current != null)
        {
            if (current.Value.ToString() == target.ToString())
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public static bool LinkedListFindRecur<T>(Node<T> head, T target)
    {
        if (head == null)
        {
            return false;
        }
        if (object.Equals(head.Value, target))
        {
            return true;
        }
        return LinkedListFindRecur<T>(head.Next, target);
    }
}

