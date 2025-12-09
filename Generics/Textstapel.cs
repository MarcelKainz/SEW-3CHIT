namespace Generics;

public class TextStapel
{
    private int pos = -1; //leerer Stapel
    private string[] daten = new string[10];

    public void Push(string number)
    {
        if (pos == daten.Length-1) throw new IndexOutOfRangeException("Das Boot ist voll");
        daten[++pos]=number; //vorher incrementieren
    }
    
    public string Pop()
    {
        if (pos == -1) throw new IndexOutOfRangeException("Leerer Stapel");
        return daten[pos--]; //nachher erniedrigen
    }
}