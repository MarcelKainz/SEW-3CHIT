namespace Fahrzeug;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("-----------------------------------------------");
        //Fahrzeug f = new Fahrzeug();
        //f.Typ();
        Console.WriteLine("-----------------------------------------------");
        Auto a = new Auto();
        a.Starten();
        Console.WriteLine(a.Typ());
        Console.WriteLine("-----------------------------------------------");
        Motorrad m = new Motorrad();
        m.Starten();
        Console.WriteLine(m.Typ());
        Console.WriteLine("-----------------------------------------------");
    }
}

public abstract class Fahrzeug
{
    public string Marke { get; set; }
    public abstract void Starten(); //keine Implementierung
    public virtual string Typ() => "Allgemeines Fahrzeug";
}

public class Auto : Fahrzeug
{
    public override void Starten()
    {
        Console.WriteLine("Auto startet");
    }

    public override string Typ()
    {
        return "Auto";
    }
}

public class Motorrad : Fahrzeug
{
    public override void Starten()
    {
        Console.WriteLine("Motorrad startet");
    } 
}