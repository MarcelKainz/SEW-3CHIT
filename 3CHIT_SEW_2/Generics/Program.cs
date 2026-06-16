namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        Zahlenstapel zs1 = new Zahlenstapel();
        //Console.WriteLine(zs1.Pop());

        for (int i = 0; i < 12; i++)
        {
            zs1.Push(i*i);
        }
        
        TextStapel ts = new TextStapel();
        ts.Push("asldk");
        ts.Push("qwe");
        ts.Push("bhduaog");
        
        GenerischerStapel<int> gs = new GenerischerStapel<int>();
        GenerischerStapel<string> csts = new GenerischerStapel<string>();
        GenerischerStapel<double> dsts = new GenerischerStapel<double>();

        GenerischerStapel<Buch> hsn = new GenerischerStapel<Buch>();
    }
}

class Buch
{
    //wuascht wos do nu drin is
}