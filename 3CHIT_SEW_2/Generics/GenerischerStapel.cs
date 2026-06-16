namespace Generics;

public class GenerischerStapel<T>
{
    private int pos = -1; //leerer Stapel
    private T[] daten = new T[10];

    public void Push(T number)
    {
        if (pos == daten.Length-1) throw new IndexOutOfRangeException("Das Boot ist voll");
        daten[++pos]=number; //vorher incrementieren
    }
    
    public T Pop()
    {
        if (pos == -1) throw new IndexOutOfRangeException("Leerer Stapel");
        return daten[pos--]; //nachher erniedrigen
    }
}