using System;



public class ScottQueries
{
    delegate void Tuwas(string egal);

    delegate void Machwas(int x, int y, string z);



/*    public static void Main(string[] args)
    {
        /*Tuwas beispiel;


        beispiel = Groß; //Variable, die auf eine Methode verweist;
        beispiel("Levakaaas");

        beispiel = Klein;
        beispiel("Levakaaas");


        beispiel = delegate(string s) { Console.WriteLine("42"); };
        beispiel("Levakaaas");

        Machwas m1 = (x, y, z) => Console.WriteLine($"{x} {y} {z}");
        Machwas m2 = (x, y, z) => Console.WriteLine($"{x} {y} {z}");

        m1(4, 9, "egal");
        m2(4, 9, "egal");

        
        string pfadEmployees = @"C:\Users\kainz\RiderProjects\3CHIT_SEW_2\LinQ\Employees.txt";
        string pfadDepts = @"C:\Users\kainz\RiderProjects\3CHIT_SEW_2\LinQ\Departments.txt";

        // Listen erstellen
        EmployeeList liste = new EmployeeList();
        DepartmentList depts = new DepartmentList();

        try
        {
            // Laden ausführen
            liste.Load(pfadEmployees);
            depts.Load(pfadDepts);

            // --- AB HIER: AUSGABE HINZUFÜGEN ---
            Console.WriteLine("\n--- DATEN-CHECK ---");
            Console.WriteLine($"Mitarbeiter geladen: {liste.Count}");
            Console.WriteLine($"Abteilungen geladen: {depts.Count}");

            if (liste.Count > 0)
            {
                Console.WriteLine("\nListe der Employees:");
                foreach (var e in liste)
                {
                    Console.WriteLine(e.PrinttoConsole());
                }
            }
            
            if (depts.Count > 0)
            {
                Console.WriteLine("\nListe der Departments:");
                
                    // Hier nutzt du die Extension Method für das einzelne Objekt
                    Console.WriteLine(depts.PrinttoConsole());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"FEHLER: {ex.Message}");
        }
    }*/


    public static void Groß(string egal)
    {
        Console.WriteLine(egal.ToUpper());

    }


    public static void Klein(string egal)
    {
        Console.WriteLine(egal.ToLower());

    }
}

