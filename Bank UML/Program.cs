// See https://aka.ms/new-console-template for more information

class Konto
{
    public string Bezeichnung {get; set;}
    public int? Betrag { get; set; }
    public int? Stand { get; set; }

    public Konto(int stand)
    {
        Betrag = null;
        Stand = stand;
    }
    public void Einzahlen(int betrag)
    {
        Stand += betrag;
        
        Console.WriteLine($"Der Kontostand beträgt nun {Stand}!");
    }
    
    public void Abheben(int betrag)
    {
        if (Stand >= betrag)
        {
            Stand -= betrag;
            Console.WriteLine($"Es wurde {betrag} vom Konto abgehoben. Der neue Kontostand beträgt {Stand}");
        }
        
        else
        {
            Console.WriteLine($"Der Kontostand ist zu gering. Sie können maximal {Stand} abheben!");
        }
    }
    
}

public abstract class Kunde
{
    
}

public class Privatkunde : Kunde
{
    public string VorName{get; set;}
    public string NachName { get; set; }
}

public class Geschäftskunde : Kunde
{
    public string FirmName { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        Konto konto1 = new Konto(200);
        
        konto1.Abheben(150);
        konto1.Einzahlen(290);
    }
}