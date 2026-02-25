namespace ScottQueries;

class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = {3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 8, 9};

        var erg1 =
            from i in numbers
            where i % 2 == 0
            orderby i descending
            select i;

        foreach (var item in erg1)
        {
            Console.WriteLine(item + " ");
        }

        Console.WriteLine();
        
        
       
    }
}