namespace Array;

class Program
{
    static void Main(string[] args)
    {
        //-- Strings
        
        string s = "HTLKrems";
        Console.WriteLine(s);
        s = s.Replace("Krems", "Zwettl");
        Console.WriteLine(s);
        s = s.Replace("t", "d");
        Console.WriteLine(s);

        //-- Array

        Console.WriteLine("-----------------------------------------------------");
        
        int[] zahlen = [ 3, 7, 17, 44, 8, 2 ];
        Console.WriteLine("Lenght: " + zahlen.Length);
        foreach (var items in zahlen)
        {
            Console.Write(items + " ");
        }
        System.Array.Resize(ref zahlen, 7);
        zahlen[6] = 1;
        Console.WriteLine(" ");
        Console.WriteLine("Lenght: " + zahlen.Length);
        /*zahlen[7] = 7;
        Console.WriteLine(" ");
        Console.WriteLine(zahlen.Length); -- Fehler Ausgabe: System.IndexOutOfRangeException: Index was outside the bounds of the array. */
        foreach (var items in zahlen)
        {
            Console.Write(items + " ");
        }
        
        //-- Liste

        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------");

        List<int> liste = new List<int>();
        liste.Add(1);
        liste.Add(2);
        liste.Add(3);
        liste.Add(4);
        liste.Add(5);
        liste.Add(6);
        liste.Add(7);
        liste.Add(8);
        liste.Add(9);
        liste.Add(10);
    }
    
    
    
}