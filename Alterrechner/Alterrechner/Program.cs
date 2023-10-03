// See https://aka.ms/new-console-template for more information

int age;
int year = DateTime.Now.Year;
int birthyear = 2008;
Console.WriteLine("Wann bist du geboren (Jahr)");
Console.Read();
age = year - birthyear;
Console.WriteLine(age);