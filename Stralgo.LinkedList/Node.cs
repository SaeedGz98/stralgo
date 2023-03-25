public class Node
{
    public Node(int value, Node next)
    {
        Value = value;
        Next = next;
    }

    public int Value { get; set; }

    public Node Next { get; set; }
}