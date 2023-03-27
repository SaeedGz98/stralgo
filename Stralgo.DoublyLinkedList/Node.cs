public class Node<T>
{
    public Node(Node<T> prev, T data, Node<T> next)
    {
        Prev = prev;
        Data = data;
        Next = next;
    }

    public Node<T> Prev { get; set; }

    public T Data { get; set; }

    public Node<T> Next { get; set; }

    public override string ToString()
    {
        return Data.ToString();
    }
}