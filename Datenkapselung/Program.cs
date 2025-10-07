// See https://aka.ms/new-console-template for more information

using Datenkapselung;

Kapsel k = new Kapsel();

//Moderner über properties
k.Inhalt1 = "Egal";             //Setter
Console.WriteLine(k.Inhalt1);   //Getter

//Konservativer über Methoden
k.SetInhalt2("Immernoch Egal");     //Set Methode
Console.WriteLine(k.GetInhalt2);    //Get Methode

Console.ReadKey();
