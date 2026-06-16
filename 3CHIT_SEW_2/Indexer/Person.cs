namespace Indexer;

public class Person
{
    public string FirstName {get; set;}
    public string LastName {get; set;}

    
    
    override public string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}

