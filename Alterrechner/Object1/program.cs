using P_2023_10_Person;

Person p = new Person("Susi", "Meier");

p.SetFirstName("Hugo");
p.LastName= "Macho";
Console.WriteLine(p.GetFirstName());
Console.WriteLine(p.LastName);
Console.WriteLine(p.FullName());
Console.WriteLine(p);

Console.WriteLine(p.GetAge());