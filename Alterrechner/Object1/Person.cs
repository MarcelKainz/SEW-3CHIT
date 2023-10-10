namespace P_2023_10_Person;

public class Person
{
    public string firstName;
    private string lastName;
    private DateTime birthday=new DateTime(2007, 10, 10);

    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.LastName = lastName;
    }

    public string GetFirstName()
    {
        return firstName;
    }

    public void SetFirstName(string value)
    {
        if (value.Length > 2)
            firstName = value;
        else
        {
            firstName = " ";
        }
            
    }

    public int GetAge()
    {
        DateTime tmp = DateTime.Now;
        int diff = tmp.Year - this.birthday.Year;
        if(tmp)
    }

    public override string ToString()
    {
        return firstName + " " + lastName;
    }

    public int GetAge()
    {
        
    }
}



/*
class Person
{
    public string firstName;

    static void Main(string[] args)
    {
        
    }
    public string GetFirstName()
    {
        return firstName;
    }

    public void SetFirstName(string value)
    {
        if (value.Length < 3)
        {
            value = "";
        }
    }

    Person x = new Person();
        x.firstName = "";
        x.lastName = "";
        Console.WriteLine(x.FirstName);
}

class Person
{
    public string FirstName;
    private string firstName;

    public string GetFirstName()
    {
        return firstName;
    }

    public void SetFirstName(string value)
    {
        if (true)
        {
            firstName = value;
        }
    }

    public string LastName
    {
        get { return lastName; }
        set{ if (true) lastName = value; }
    } 
Person p = new Person();
p.set FirstName("Herwig");
p.Lastname = "Macho";
Console.WriteLine(p GetLastName());
Console.WriteLine(p.Lastname);

/*
class Person
{
    string firstName;
    string lastName;

    Person p = new Person("Herwig", "Macho");
    //Constructor
    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
    }

    public override string ToString()
    {
        return firstName + " " + lastName;
    }
    Console.Write(Person.FullName());
    Console.Write(p);
}

/* Theorie
 class
1) Namen
2) priv.Var + öffGetSet }- property
3) Konstruktor
4) "Selbstdarstellung" toString()
5) Methoden
*/