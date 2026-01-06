
using System.Runtime.CompilerServices;

namespace Structy_CS.LinkedList_1;


public class Node<T>(T value, Node<T>? next = null)
{
    public T Value { get; set; } = value;
    public Node<T>? Next { get; set; } = next;
    
}

public static partial class LinkedList1
{
    
}

