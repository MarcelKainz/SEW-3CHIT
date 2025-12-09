namespace DoubleLinkedList;

public class DoubleLinkedList
{
    public Node Head { get; set; }
    public Node Tail { get; set; }
    public int Count { get; private set; }
    
    public void AddFirst(int value)
    {
        Node newNode = new Node { Value = value };
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
        }
        Count++;
    }
    
    
    public void AddLast(int value)
    {
        Node newNode = new Node { Value = value };
        if (Tail == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            newNode.Previous = Tail;
            Tail = newNode;
        }
        Count++;
    }
    
    public void Remove(int value)
    {
        Node current = Head;
        while (current != null)
        {
            if (current.Value == value)
            {
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    Head = current.Next;
                }

                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    Tail = current.Previous;
                }

                Count--;
                return;
            }
            current = current.Next;
        }
    }
}