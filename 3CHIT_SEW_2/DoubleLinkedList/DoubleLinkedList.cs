using System.Text;
using DoubleLinkedList;

public class DoubleLinkedList<T> : IComparable<T> where T : IComparable<T>
{
    public Node<T> Head { get; set; }
    public Node<T> Tail { get; set; }
    public int Count { get; private set; }
    
    public void AddFirst(T value)
    {
        Node<T> newNode = new Node<T> { Value = value };
        Count++;
    
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
            return;
        }
    
        newNode.Next = Head;
        Head.Previous = newNode; // Den alten Head rückwärts verbinden
        Head = newNode;
    }
    
    
    public void AddLast(T value)
    {
        Node<T> newNode = new Node<T> { Value = value };
        Count++;

        if (Tail == null)
        {
            Head = newNode;
            Tail = newNode;
            return;
        }

        Tail.Next = newNode;     // Den alten Tail nach vorne verbinden
        newNode.Previous = Tail; // Den neuen Knoten nach hinten verbinden
        Tail = newNode;          // Tail-Zeiger aktualisieren
    }
    
    
    public Node<T> Find (T value)
    {
        Node<T> tmp = Head;
        if (tmp == null)
        {
            return null;
        }

        while (tmp != null)
        {
            object o = new object();
            o.Equals(value);
                
            if (tmp.Value.Equals(value))
                return tmp;
            if (tmp.Value.CompareTo(value) == 0)
            {
                tmp = tmp.Next;
            }
        }

        return tmp;
    }
    
    public void Remove(T value)
    {
        Node<T> current = Head;
        while (current != null)
        {
            if (current.Value.CompareTo(value) == 0)
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

    public int CompareTo(T? other) 
    {
        throw new NotImplementedException();
    }
    
    
    public override string ToString()
    {
        /*if (Head == null)
        {
            return "Liste ist leer.";
        }

        // Wir nutzen den Node-eigenen ToString Mechanismus (rekursiv)
        return Head.ToString();*/
        StringBuilder sb = new StringBuilder();
        sb.Append($"{Count} Elemente, Head: ->");
        
        Node<T> tmp = Head;
        while (tmp.Next != null)<a3
        {
            sb.Append($"{tmp.Value}");
            if(tmp.Next != null) sb.Append($" <--> ");
            tmp = tmp.Next;
        }
        sb.Append($" <-Tail");
        return sb.ToString();
    }
}