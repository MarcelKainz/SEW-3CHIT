// See https://aka.ms/new-console-template for more information

class Konto
{
    public string Bezeichnung {get; set;}
    public int Betrag { get; set; }

    public Konto(int betrag)
    {
        Betrag = betrag;
    }
    
    public void Abheben(int betrag)
    {
        if (stand <= betrag)
        {
            
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