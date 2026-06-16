namespace DoubleLinkedList;

public class Node<T>
{
    public T Value { get; set; }
    public Node<T> Next { get; set; }
    public Node<T> Previous { get; set; }
    
    public override string ToString()
    {
        return Next == null ? Value + "->(null)":
            Value + "<->" + Next.ToString();
    }
     
    public void CompareTo(T other)
    {
        if (Value is IComparable<T> comparable)
        {
            comparable.CompareTo(other);
        }
        else
        {
            throw new InvalidOperationException("Type T does not implement IComparable<T>");
        }   
    }
}