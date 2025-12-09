namespace Generics;

public class Zahlenstapel
{
    private int pos = -1; //leerer Stapel
    private int[] zahlen = new int[10];

    public void Push(int number)
    {
        if (pos == zahlen.Length-1) throw new IndexOutOfRangeException("Das Boot ist voll");
        zahlen[++pos]=number; //vorher incrementieren
    }
    
    public int Pop()
    {
        if (pos == -1) throw new IndexOutOfRangeException("Leerer Stapel");
        return zahlen[pos--]; //nachher erniedrigen
    }
}