using BinaryTree;

class Program
{
    static void Main(string[] args)
    {
        MyBinaryTree<int> b = new MyBinaryTree<int>();
        
        b.Insert(new MyNode<int>{Value = 5});
        b.Insert(new MyNode<int>{Value = 7});
        b.Insert(new MyNode<int>{Value = 3});
        b.Insert(new MyNode<int>{Value = 1});
        b.Insert(new MyNode<int>{Value = 8});
        
        b.Find(1);
        b.Find(9);

        Console.WriteLine("\n------------------------------------------------");
        Console.WriteLine("PreOrder:");
        b.Traversal(Order.PreOrder);
        Console.WriteLine("\n-----------------------------------------------");
        Console.WriteLine("InOrder:");
        b.Traversal(Order.InOrder);
        Console.WriteLine("\n-----------------------------------------------");
        Console.WriteLine("PostOrder:");
        b.Traversal(Order.PostOrder);
        Console.WriteLine("\n-----------------------------------------------");

    }
}