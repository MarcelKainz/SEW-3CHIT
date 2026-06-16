using DoubleLinkedList;

class Program
{
    static void Main(string[] args)
    {
        // Hier konkret <int> angeben
        DoubleLinkedList<int> dl = new DoubleLinkedList<int>();
        dl.AddFirst(10);
        dl.AddFirst(20);
        dl.AddLast(5);
        dl.Remove(20);

        // Tipp: Du müsstest in DoubleLinkedList noch ToString() überschreiben,
        // damit du ein Ergebnis in der Konsole siehst.
        Console.WriteLine("Fertig!");
        Console.WriteLine(dl.Count + " Elemente: " + "Head: " + dl.ToString());

        DoubleLinkedList<Person> dl3 = new DoubleLinkedList<Person>();
        
        dl3.AddLast(new Person() { FirstName = "Max", LastName = "Mustermann" });
        dl3.AddLast(new Person() { FirstName = "Erika", LastName = "Musterfrau" });
        Console.WriteLine("Personenliste: " + dl3.ToString());

        var f3 = dl3.Find(new Person() { FirstName = "John", LastName = "Doe" });
        if (f3 != null)
        {
            Console.WriteLine(f3);
        }
        else
        {
            Console.WriteLine("new John Doe not found");
        }

        var f4 = dl3.Find(john);
        if (f4 != null)
        {
            Console.WriteLine("Old John Doe found: " + f4);
        }
        else
        {
            Console.WriteLine("Old John Doe not found");
        }
    }
}