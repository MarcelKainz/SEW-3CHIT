namespace BinaryTree;

public class MyNode<T>
{
    public T Value { get; set; }
    
    //Kein Konstruktor benötigt
    
    public MyNode<T> Left { get; set; }
    public MyNode<T> Right { get; set; }
}