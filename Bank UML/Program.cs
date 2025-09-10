// See https://aka.ms/new-console-template for more information

class Konto
{
    public string Bezeichnung {get; set;}

    public void Abheben()
    {
        
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