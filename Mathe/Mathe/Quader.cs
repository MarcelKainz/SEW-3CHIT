namespace MatheLib;

/// <summary>
/// Class Kreis
/// Author: Philipp ANDERL, 2chit
/// </summary>
public class Quader
{
    private int height;
    private int length;
    private int width;

    public Quader(int height, int length, int width)
    {
        this.height = height;
        this.width = width;
        this.length = length;
    }

    public int Volumen()
    {
        return length * height * width;
    }

    public int Oberflaeche()
    {
        return (2 * length * width) + (2 * length * height) + (2 * height * width);
    }
}