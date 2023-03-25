using System.Text;

public class LinkedList
{
    private Node Head;

    public LinkedList()
    {
        Head = null;
    }

    public void Add(int value)
    {
        Node node = new(value, null);

        if (Head == null)
        {
            Head = node;
        }
        else
        {
            Node current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = node;
        }
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();
        Node current = Head;

        while (current != null)
        {
            stringBuilder.Append(current.Value + " ");
            current = current.Next;
        }

        return stringBuilder.ToString();
    }
}