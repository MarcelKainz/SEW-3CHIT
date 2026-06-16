namespace DoubleLinkedList;

public class Person:IComparable<Person>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int CompareTo(Person? other)
    {
        // Wertegleichheit
        if (FirstName == other.FirstName)
        {
            return LastName.CompareTo(other.LastName);
        }
        return FirstName.CompareTo(other.FirstName);
        /*  referenzielle Gleichheit
            return this.Equals(other) ? 0 : 1;
        */
        
    }

    public override string ToString()
        => $"{FirstName} {LastName}";
}