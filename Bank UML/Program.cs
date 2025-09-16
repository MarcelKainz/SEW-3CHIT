// See https://aka.ms/new-console-template for more information

class Konto(int i)
{
    public string description;
    public decimal? balance; //Euro
    List<Customer> _myCust = new List<Customer>();

    public decimal Balance
    {
        get{return (decimal)balance;}
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

public abstract class Customer
{
    
}

public class PrivateCustomer : Customer
{
    public string VorName{get; set;}
    public string NachName { get; set; }
}

public class BusinessCustomer : Customer
{
    public string FirmName { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        Konto konto1 = new Konto(200);
        
        konto1.withdraw(150);
        konto1.deposit(290);
    }
}