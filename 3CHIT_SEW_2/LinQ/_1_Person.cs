using _1_Person;

Person[] family = new []
{
    new Person{FirstName = "John", LastName = "Doe", Born = new DateTime(1980, 01, 01)},
    new Person{FirstName = "Jane", LastName = "Doe", Born = new DateTime(1980, 01, 02)},
    new Person{FirstName = "Jim", LastName = "Doe", Born = new DateTime(2009, 01, 03)}
};

var children =
    from person in family
    where person.Born > new DateTime(2000, 01, 01)
    select new { FirstName = person.FirstName, LastName = person.LastName, Born = person.Born.Year };

Console.WriteLine(children.FirstOrDefault());

var youngsters = family
    .Where(x => x.Born > new DateTime(2000, 01, 01))
    .Select(x => new {FirstName = x.FirstName, LastName = x.LastName, Born = x.Born.Year});

Console.WriteLine(youngsters.FirstOrDefault());