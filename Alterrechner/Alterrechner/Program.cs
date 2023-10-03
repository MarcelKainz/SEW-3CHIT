// See https://aka.ms/new-console-template for more information

int age;
int year = DateTime.Now.Year;
int birthyear;
Console.WriteLine("Wann bist du geboren (Jahr)");
birthyear = Console.Read();
age = year - birthyear;
Console.WriteLine(year);
Console.WriteLine(age);