namespace Mahlzeit;

public abstract class Mahlzeit
{}

public class Pizza: Mahlzeit
{
    public Pizza()
    {
        Console.WriteLine("Pizza gebacken");
    }
}

public class Bratwurst : Mahlzeit
{
    public Bratwurst(string beilage)
    {
        Console.WriteLine("Bratwurst gebraten");
        if (!string.IsNullOrEmpty(beilage))
        {
            Console.WriteLine("Serviert mit "+beilage);
        }
    }
}

public class Kaffee : Mahlzeit
{
    public Kaffee(string kuchen)
    {
        Console.WriteLine("Kaffee gekocht");
        if (!string.IsNullOrEmpty(kuchen))
        {
            Console.WriteLine("Serviert mit "+kuchen);
        }
    }
}

