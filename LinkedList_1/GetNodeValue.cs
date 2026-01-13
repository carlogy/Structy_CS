
namespace Structy_CS.LinkedList_1;

public static partial class LinkedList1
{
    public static T? GetNodeValueItr<T>(Node<T> head, int index)
    {
        var current = head;
        var currentInd = 0;
        while (current != null)
        {
            if (currentInd == index)
            {
                return current.Value;
            } 
            
            currentInd++;
            current = current.Next;
        }
        return default(T);
    }

    public static T? GetNodeValueRecur<T>(Node<T>? head, int index)
    {
        if (head == null)
        {
            return default(T);
        }

        if (index == 0)
        {
            return head.Value;
        }

        return GetNodeValueRecur(head.Next, index - 1);
    }
}

