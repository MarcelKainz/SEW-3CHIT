namespace MatheLib;

/// <summary>
/// Class Kreis
/// Author: Tatjana PILZ, 2chit
/// </summary>
public class Kugel
{
    private int radius;

    public Kugel(int radius)
    {
        this.radius = radius;
    }

    public double Flaeche()
    {
        double flaeche = 4 * Math.PI * radius * radius;
        return flaeche;
    }

    public double Umfang()
    {
        double umfang = 2 * Math.PI * radius;
        return umfang;
    }
}