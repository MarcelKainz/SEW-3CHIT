// See https://aka.ms/new-console-template for more information

class Konto
{
    public string description;
    public decimal? balance; //Euro
    List<Customer> _myCust = new List<Customer>;

    public decimal Balance
    {
        get{return balance;}
    }
    
    public void deposit(decimal amount)
    {
        if (amount < 0)
        {
            balance += amount;
            Console.WriteLine($"Es wurde {amount} dem Konto hinzugefügt. Der neue Kontostand beträgt {balance}");
            
        }
        else
            throw new Exception("Bitte hebe Geld ab");
    }
    
    public void withdraw(decimal amount)
    {
        if (balance >= amount && amount > 0)
        {
            balance -= amount;
            Console.WriteLine($"Es wurde {amount} vom Konto abgehoben. Der neue Kontostand beträgt {balance}");
        }
        
        else
        {
            Console.WriteLine($"Der Kontostand ist zu gering. Sie können maximal {balance} abheben!");
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