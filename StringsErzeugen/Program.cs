// See https://aka.ms/new-console-template for more information
using System.Text;


string res = "";
for (int i = 0; i < 100000; i++)
    res += "x"; // never do this again

Console.WriteLine(res.Length);

StringBuilder sb = new StringBuilder();
for (int i = 0; i < 1000000000; i++)
    sb.Append("x");//goes pigfast
res = sb.ToString();
Console.WriteLine(res.Length);

