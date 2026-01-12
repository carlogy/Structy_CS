
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
}

