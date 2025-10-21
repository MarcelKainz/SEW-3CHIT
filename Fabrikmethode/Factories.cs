namespace Mahlzeit;

public abstract class Restaurant
{
    public Mahlzeit mahlzeit { get;protected set; }     //kann von außen zugegriffen werden, aber nicht geändert werden
    protected abstract void MahlzeitZubereiten();

    protected virtual void BestellungAufnehmen()
    {
        Console.WriteLine("Ihre Bestellung bitte!");
    }

    //
    
    protected virtual void MahlzeitServieren()
    {
        Console.WriteLine("Hier ihre Mahlzeit. Guten Appetit!");
    }

    public void MahlzeitLiefern()
    {
        BestellungAufnehmen();
        MahlzeitZubereiten();
        MahlzeitServieren();
    }
}

public class Pizzeria : Restaurant
{
    protected override void MahlzeitZubereiten()
    {
        mahlzeit = new Pizza();
    }
}

public class Bratwurststand : Restaurant
{
    protected override void MahlzeitZubereiten()
    {
        mahlzeit = new Bratwurst("Pommes und Ketchup");
    }
    protected override void MahlzeitServieren()
    {
        Console.WriteLine("Mahlzeit serviert.");
    }
}

public class Kaffeehaus : Restaurant
{
    protected override void BestellungAufnehmen()
    {
        Console.WriteLine("Wollen Sie einen Kuchen dazu?");
    }

    protected override void MahlzeitZubereiten()
    {
        mahlzeit = new Kaffee("Apfelstrudel");
    }
}
// Copyright Keinrath