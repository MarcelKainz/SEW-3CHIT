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
    
    public void AddBefore(int tgV, int nV)
    {
        MyElement tmp = Head;

        if (Head == null)
            return;

        if (Head.Value == tgV)
        {
            AddFirst(nV);
            return;
        }

        while (tmp.Next != null && tmp.Next.Value != tgV)
        {
            tmp = tmp.Next;
        }

        if (tmp.Next != null)
        {
            MyElement newElement = new MyElement { Value = nV };
            newElement.Next = tmp.Next;
            tmp.Next = newElement;
            Count++;
        }
    }
    
    public void AddAfter(int tgv, int newValue)
    {
        MyElement tmp = Head;

        if (tmp == null)
        {
            throw new Exception("Empty list - cannot add after");
        }

        if (tgv == null)
        {
            throw new Exception("Empty Element - cannot add after");
        }
        
        while (tmp != null && tmp.Value != tgv)
        {
            tmp = tmp.Next;
        }

        if (tmp != null)
        {
            MyElement newElement = new MyElement { Value = newValue };
            newElement.Next = tmp.Next;
            tmp.Next = newElement;
            Count++;
        }

        else
        {
            throw new Exception("Target value not found - cannot add after");
        }
    }
    
    public MyElement Find(int value)
    {
        MyElement tmp = Head;

        while (tmp != null)
        {
            if (tmp.Value == value)
                return tmp;
            tmp = tmp.Next;
        }

        return null;
    }
    
    public override string ToString()
    {
        return $"{Count} Elements: ->" + Head.ToString();
    }
}

