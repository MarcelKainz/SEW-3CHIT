using System.Globalization;

namespace Datenkapselung;

public class Kapsel
{
    private string inhalt1;
    private string inhalt2;
    
    //Schnittstelle für Zugriff auf Inhalt!
    public string Inhalt1
    {
        get { return inhalt1; }
        set { inhalt1 = value; }
    }
    
    //Schnittstelle für Inhalt2
    // Get-Methode
    public string GetInhalt2(){return inhalt2;}
    //Set-Methode
    public void SetInhalt2(string value){inhalt2 = value;}
    
    
}