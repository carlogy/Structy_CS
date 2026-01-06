
namespace Structy_CS.LinkedList_1;

public static partial class LinkedList1
{
    public static List<T> LinkedListValuesItr<T>(Node<T> head)
    {
        var values = new List<T>();
        var current = head;
        do
        {
            values.Add(current.Value);
            current = current.Next;
        
        } while (current != null);

        return values;
    }

    public static List<T> LinkedListValuesRecur<T>(Node<T> head)
    {
        var values = new List<T>();
        var results = linkedListValuesHelper(head, values);
        return results;
    }

    private static List<T> linkedListValuesHelper<T>(Node<T> head, List<T> values)
    {
        if (head == null)
        {
            return values;
        }
        else
        {
            values.Add(head.Value);
            return LinkedList1.linkedListValuesHelper<T>(head.Next, values);
        }
    }
}