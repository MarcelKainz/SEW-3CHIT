// See https://aka.ms/new-console-template for more information
using Indexer;

Person max = new Person{FirstName="Max", LastName = "Verstappen"};
Person shuki = new Person{FirstName="Xandl", LastName="Schuecker"};

Formel1Piloten f1 = new Formel1Piloten();

// Zugriff über Indexer
f1[1]=max;
f1[13]=shuki;

// Zugriff über Assoziatives Array
// über string-basierten Indexer
Person p1 = f1["Max Verstappen"];
Person p2 = f1["Xandl Schuecker"];
Person p3 = f1["Herbig Macho"];

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);

f1["Marvin Pauer"]=new Person{FirstName="Marvin", LastName="Pauer"};

Console.WriteLine(f1);

//Not so beautiful
for (int i = 0; i < 99; i++)
{
    if (f1[i] != null)
        Console.WriteLine($"{i+1}: {f1[i]}");
}

foreach (var person in f1)
{
    if (person != null)
        Console.WriteLine(person);
}

Client Formel1 = new Client(f1, new PilotenIterator(f1));
Formel1.Ausgabe();

class Client
{
    Formel1Piloten f1;
    PilotenIterator iter;

    public Client(Formel1Piloten data, PilotenIterator iter)
    {
        f1 = data;
        this.iter = iter;
    }

    public void Ausgabe()
    {
        while (iter.MoveNext() != null)
        {
            Console.WriteLine(iter.Current);
        }
    }
}