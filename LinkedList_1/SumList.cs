
namespace Structy_CS.LinkedList_1;

public static partial class  LinkedList1
{
    public static int SumListItr<T>(Node<T> head)
    {
        var sum = 0;
        var current = head;
        do
        {
            sum += Convert.ToInt32(current.Value);
            current = current.Next;

        } while (current != null);
        
        return sum;
    }


    public static int SumListRecur<T>(Node<T> head)
    {
        
        var sum = SumHelper(head, 0);
        return sum;
    }



    private static int SumHelper<T>(Node<T> head, int sum) {

        if (head == null)
        {
            return sum;
        }
        sum += Convert.ToInt32(head.Value);
        return SumHelper(head.Next, sum);
    }
}

