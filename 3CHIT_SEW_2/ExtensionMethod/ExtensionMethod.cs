namespace ExtensionMethod;


public static class MyExtensions
{
    public static int Square(this int i)
    {
        return i * i;
    }
    
    /// <summary>
    /// To Hex - Convert an Integer to its Hexadecimal Value
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>

    public static string ToHex(this int x) => x.ToString("X");

    
    
}