namespace Linked_List;

public class MyLinkedList
{
    private MyElement head;
    private MyElement tail;
    private int count;

    public MyLinkedList()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public void AddFirst(int value)
    {
        MyElement newElement = new MyElement(value);
        if (head == null)
        {
            head = newElement;
            tail = newElement;
        }
        else
        {
            newElement.Next = head;
            head = newElement;
        }
        count++;
    }

    public void AddLast(int value)
    {
        MyElement newElement = new MyElement(value);
        if (tail == null)
        {
            head = newElement;
            tail = newElement;
        }
        else
        {
            tail.Next = newElement;
            tail = newElement;
        }
        count++;
    }

    public int Count()
    {
        return count;
    }
}