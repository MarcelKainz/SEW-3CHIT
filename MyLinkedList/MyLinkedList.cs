namespace MyList;


public class MyLinkedList
{
    public MyElement Head { get; private set; }

    public void AddFirst(int value)
    {
        MyElement tmp = new MyElement { Value = value };
        tmp.Next = Head;
        Head = tmp;
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
    }

    public override string ToString()
    {
        return Head.ToString();
    }
}