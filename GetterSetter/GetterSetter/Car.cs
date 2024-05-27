using System;
using GetterSetter;

public class Car
{
    private string color;
    private int power;
    private string brand;

    //No Constructor ;) LOL

    #region get-set-methode

    //Methode
    public string GetColor()
    {
        return color;
    }

    public void SetColor(string value)
    {
        color = value;
    }

    public int GetPower()
    {
        return power;
    }

    public void SetPower(int value)
    {
        if (value < 0)
            throw new Exception("no negative Power");

        power = value;
    }

    #endregion get-set-methode

    #region getter-setter

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    #endregion

    //Getter-Setter

    //Kurz Variante getter/setter ohne private Variable
    //Wenn man keine ifs braucht reicht diese Kurzvariante
    public int WheelDeimension { get; set; }
}