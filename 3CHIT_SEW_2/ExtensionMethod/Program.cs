using ExtensionMethod;
using static ExtensionMethod.MyExtensions;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(33.Square());
        Console.WriteLine(33.ToHex());
        Console.WriteLine(33.Square().ToHex());
    }
}
