namespace AnonymeTypen;

class Program
{
    static void Main(string[] args)
    {
        // eigentlich implizit typisierte lokale Variablen
        var a1 = new {FirstName = "Sebastian", LastName="Kainz"};
        var a2 = new {FirstName="Stefan", LastName="Thaler"};
        var a3 = new {LastName="Thaler", FirstName="Stefan"};
        var a4 = new() {LastName="Thaler", FirstName="Stefan"};

        
        // eigentlich implizit typisierte lokale Variablen
        var p1 = new Person { FirstName = "John", LastName = "Doe" };
        var p2 = new Person { FirstName = "Jane", LastName = "Doe" };
        var p3 = new Person { LastName = "Doe", FirstName = "Jim" };
        
        // seit kurzem:
        Person p4 = new() { LastName = "Doe", FirstName = "Jim" };

        a1 = a2;
        // a1 = a3; // {Fn, Ln} <> {Ln, Fn}
        
        p1 = p2;
        p1 = p3; // Person bleibt Person
    }
}

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
}
