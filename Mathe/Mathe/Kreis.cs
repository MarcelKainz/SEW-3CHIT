namespace MatheLib;

/// <summary>
/// Class Kreis
/// Author: Marcel KAINZ, 2chit
/// </summary>
public class Kreis
{
    int radius;

    public Kreis(int radius)
    {
        this.radius = radius;
    }

    /// <summary>
    /// Berechne den Umfang des Kreises
    /// </summary>
    /// <returns></returns>
    public double Umfang()
    {
        double umfang = 2 * radius * Math.PI;
        return umfang;
    }

    /// <summary>
    /// Berechnet die Fläche des Kreises
    /// anhand der Formel r²*PI
    /// </summary>
    /// <returns>double</returns>
    public double Flaeche()
    {
        double flaeche = radius * radius * Math.PI;
        return flaeche;
    }
}