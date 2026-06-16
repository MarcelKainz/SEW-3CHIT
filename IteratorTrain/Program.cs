// See https://aka.ms/new-console-template for more information

using System.Drawing;
using System.Net.Quic;
using IteratorTrain;


Wagon a = new Wagon{Capacity = 48, Color="green"};
Wagon b = new Wagon{Capacity = 64,Color="yellow"};
Wagon c = new Wagon{Capacity = 56, Color="red"};

//c.Next=b;
//b.Next=a;

Train vindobona = new Train();
vindobona.Add(a);
vindobona.Add(b);
vindobona.Add(c);

Console.WriteLine(vindobona.ToString());


foreach (var wagon in vindobona)
{
    Console.WriteLine(wagon);
}