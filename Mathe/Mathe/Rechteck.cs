namespace MatheLib;

/// <summary>
/// Class Kreis
/// Author: Dominik HIPP, 2chit
/// </summary>
public class Rechteck
{
    private int breite;
    private int hoehe;

    public Rechteck(int b, int h)
    {
        breite = b;
        hoehe = h;
    }
    
    public int Flaeche()
    {
        int f;
        f = breite * hoehe;
        return f;
    }

    public int Umfang()
    {
        int u;
        u = 2 * breite + 2 * hoehe;
        return u;
    }
}