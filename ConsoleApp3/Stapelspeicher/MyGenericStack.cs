namespace Stapelspeicher;

public class MyGenericStack<T>
{
    T[] content;
    int pos;

    public MyGenericStack(int size)
    {
        content = new T[size];
    }

    public void Push(T value)
    {
        content[pos++] = value;
    }

    public T Pop()
    {
        return content[--pos];
    }
}