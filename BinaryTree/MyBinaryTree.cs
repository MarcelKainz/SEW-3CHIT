namespace BinaryTree;

public enum Order { PreOrder, InOrder, PostOrder }

public class MyBinaryTree<T> where T : IComparable<T>
{
    public MyNode<T> Root { get; private set; }

    public void Insert(MyNode<T> toAdd)
    {
        // Special Case: Tree is empty
        if (Root == null)
        {
            Root = toAdd;
            return; //habe fertig
        }
        Insert(toAdd, Root);

    }

    private void Insert(MyNode<T> toAdd, MyNode<T> currentNode)
    {
        if (toAdd.Value.CompareTo(currentNode.Value) < 0)
        {
            if(currentNode.Left == null)
            {
                currentNode.Left = toAdd;
            }
            else
            {
                Insert(toAdd, currentNode.Left);
            }
        }
        else
        {
            if(currentNode.Right == null)
            {
                currentNode.Right = toAdd;
            }
            else
            {
                Insert(toAdd, currentNode.Right);
            }
        }
    }

    public void Traversal(Order order)
    {
        if (Root == null)
        {
            Console.WriteLine("empty");
            return;
        }

        switch (order)
        {
            case Order.InOrder:
                InOrderTraversal(Root);
                break;
            case Order.PreOrder:
                PreOrderTraversal(Root);
                break;
            case Order.PostOrder:
                PostOrderTraversal(Root);
                break;
        }
    }
    
    private void PreOrderTraversal(MyNode<T> currentNode)
    {
        if (currentNode == null) return;
        Console.Write("        " + currentNode.Value);
        PreOrderTraversal(currentNode.Left);
        PreOrderTraversal(currentNode.Right);
    }

    private void InOrderTraversal(MyNode<T> currentNode)
    {
        if (currentNode == null) return;
        InOrderTraversal(currentNode.Left);
        Console.Write("        " + currentNode.Value);
        InOrderTraversal(currentNode.Right);
    }
    
    private void PostOrderTraversal(MyNode<T> currentNode)
    {
        if (currentNode == null) return;
        PostOrderTraversal(currentNode.Left);
        PostOrderTraversal(currentNode.Right);
        Console.Write("        " + currentNode.Value);
    }

    public void Find(T value)
    {
        MyNode<T> foundNode = Find(value, Root);

        if (foundNode != null)
        {
            Console.WriteLine($"Found: {foundNode.Value}");
        }
        else
        {
            Console.WriteLine("Not Found");
        }
    }

    private MyNode<T> Find(T value, MyNode<T> currentNode)
    {
        if (currentNode == null)
        {
            return null;
        }

        int comparison = value.CompareTo(currentNode.Value);

        if (comparison == 0)
        {
            return currentNode;
        }
        else if (comparison < 0)
        {
            return Find(value, currentNode.Left);
        }
        else
        {
            return Find(value, currentNode.Right);
        }
    }

    // Entfernt den Knoten mit dem gegebenen Wert (falls vorhanden)
    public void Remove(T value)
    {
        Root = RemoveNode(Root, value);
    }

    private MyNode<T> RemoveNode(MyNode<T> node, T value)
    {
        if (node == null) return null;

        int cmp = value.CompareTo(node.Value);
        if (cmp < 0)
        {
            node.Left = RemoveNode(node.Left, value);
        }
        else if (cmp > 0)
        {
            node.Right = RemoveNode(node.Right, value);
        }
        else
        {
            // gefunden
            if (node.Left == null) return node.Right;
            if (node.Right == null) return node.Left;

            // zwei Kinder: In-Order-Nachfolger (kleinster im rechten Teilbaum)
            MyNode<T> successor = FindMin(node.Right);
            node.Value = successor.Value;
            node.Right = RemoveNode(node.Right, successor.Value);
        }

        return node;
    }

    private MyNode<T> FindMin(MyNode<T> node)
    {
        while (node.Left != null) node = node.Left;
        return node;
    }
}
