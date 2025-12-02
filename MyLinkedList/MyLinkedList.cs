namespace MyList;


public class MyLinkedList
{
    public MyElement Head { get; private set; }
    public int Count { get; private set; }

    public void AddFirst(int value)
    {
        MyElement tmp = new MyElement { Value = value };
        tmp.Next = Head;
        Head = tmp;
        
        Count++;
    }

    public void AddLast(int value)
    {
        MyElement tmp = Head;
        if (tmp == null)
            Head = new MyElement { Value = value };
        else
        {
            while (tmp.Next != null)
            {
                tmp = tmp.Next;
            }

            tmp.Next = new MyElement{Value = value};
        }

        Count++;
    }

    public void Remove(int value)
    {
        MyElement tmp = Head;
        
        if (Head == null)
            return;

        if (Head.Value == value)
        {
            Head = Head.Next;
            Count++;
            return;
        }

        while (tmp.Next != null && tmp.Next.Value != value)
        {
            tmp = tmp.Next;
        }

        if (tmp.Next != null)
        {
            tmp.Next = tmp.Next.Next;
            Count++;
        }
    }
    
    
    public override string ToString()
    {
        return $"{Count} Elements: ->" + Head.ToString();
    }
}

