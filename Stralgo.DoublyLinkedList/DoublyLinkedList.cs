using System.Text;
using System.Xml.Linq;

public class DoublyLinkedList<T>
{
    private Node<T> Head { get; set; }

    private Node<T> Tail { get; set; }

    private int Size { get; set; }

    public void Clear()
    {
        Node<T> trav = Head;

        while (trav != null)
        {
            Node<T> next = trav.Next;

            trav.Prev = trav.Next = null;
            trav.Data = default;

            trav = next;
        }

        Head = Tail = trav = null;

        Size = 0;
    }

    public int GetSize()
    {
        return Size;
    }

    public bool IsEmpty()
    {
        return GetSize() == 0;
    }

    public void AddFirst(T elem)
    {
        if (IsEmpty())
        {
            Head = Tail = new(null, elem, null);
        }
        else
        {
            Head.Prev = new Node<T>(null, elem, Head);
            Head = Head.Prev;
        }

        Size++;
    }

    public void AddLast(T elem)
    {
        if (IsEmpty())
        {
            Head = Tail = new(null, elem, null);
        }
        else
        {
            Tail.Next = new(Tail, elem, null);
            Tail = Tail.Next;
        }

        Size++;
    }

    public T PeekFirst()
    {
        CheckNotEmpty();

        return Head.Data;
    }

    public T PeekLast()
    {
        CheckNotEmpty();

        return Tail.Data;
    }

    public T RemoveFirst()
    {
        CheckNotEmpty();

        T data = Head.Data;

        Head = Head.Next;

        Size--;

        if (IsEmpty())
            Tail = null;
        else
            Head.Prev = null;

        return data;
    }

    public T RemoveLast()
    {
        CheckNotEmpty();

        T data = Tail.Data;

        Tail = Tail.Prev;

        Size--;

        if (IsEmpty())
            Head = null;
        else
            Tail.Next = null;

        return data;
    }

    public T Remove(Node<T> node)
    {
        CheckNotEmpty();

        if (node.Prev == null) return RemoveFirst();
        if (node.Next == null) return RemoveLast();

        node.Prev.Next = node.Next;
        node.Next.Prev = node.Prev;

        Size--;

        T data = node.Data;

        node.Data = default;
        node.Prev = node.Next = null;

        return data;
    }

    public T RemoveAt(int index)
    {
        CheckNotEmpty();

        if (index < 0 || index >= Size)
            throw new InvalidOperationException();

        Node<T> trav;

        if (index < Size / 2)
        {
            trav = Head;
            for (int i = 0; i != index; i++)
            {
                trav = trav.Next;
            }
        }
        else
        {
            trav = Tail;

            for (int i = Size - 1; i != index; i--)
            {
                trav = trav.Prev;
            }
        }

        return Remove(trav);
    }

    public void CheckNotEmpty()
    {
        if (IsEmpty())
            throw new InvalidOperationException();
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();
        Node<T> current = Head;

        while (current != null)
        {
            stringBuilder.Append(current.Data.ToString() + " ");
            current = current.Next;
        }

        return stringBuilder.ToString();
    }
}