using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Text.RegularExpressions;

namespace DBScott;

public class LINQ_PP
{
    // Pfade zu den Dateien
    private static string BasePath = @"C:\Users\kainz\RiderProjects\ScottBlazor_V1\ScottDLL\bin\";
    private string DeptPath = Path.Combine(BasePath, "depts.txt");
    private string EmpPath = Path.Combine(BasePath, "emps.txt");

    public static void Main()
    {
        var programm = new LINQ_PP();
        programm.Aufgaben2();
    }

    public void Aufgaben()
    {
        // Daten per StreamReader laden
        List<Dept> depts = LoadDepts(DeptPath);
        List<Emp> emps = LoadEmps(EmpPath);

        var alleFilialen = depts.ToList();
        Console.WriteLine("--- Übung 1: Alle Filialen ---");
        foreach (var d in alleFilialen) Console.WriteLine($"{d.DNAME} in {d.LOC}");

        var uebung2 = emps
            .Where(e => e.DEPTID == 10)
            .ToList();

        Console.WriteLine("\n--- Übung 2: Dept 10 ---");
        PrintEmps(uebung2);

        var uebung3 = emps
            .Where(e => e.JOB == "CLERK")
            .ToList();

        Console.WriteLine("\n--- Übung 3: Büroangestellte ---");
        PrintEmps(uebung3);

        var uebung4 = emps
            .Where(e => e.DEPTID != 10)
            .ToList();

        Console.WriteLine("\n--- Übung 4: Alle außer Dept 10 ---");
        PrintEmps(uebung4);
        
        var uebung5 = emps
            .Where(e => e.COMM > e.SAL)
            .ToList();
        
        Console.WriteLine("\n--- Übung 5: Mehr Provision als Gehalt ---");
        PrintEmps(uebung5);
        
        var uebung6 = emps
            .Where(e => e.HIREDATE == new DateOnly(1981, 12, 17))
            .ToList();

        Console.WriteLine("\n--- Übung 6: Mehr Provision als Gehalt ---");
        PrintEmps(uebung6);

        var uebung7 = emps
            .Where(e => e.SAL < 1250 || e.SAL > 1600)
            .ToList();

        Console.WriteLine("\n--- Übung 7: Gehalt < 1250 oder > 1600 ---");
        PrintEmps(uebung7);

        var uebung8 = emps
            .Where(e => e.JOB != "MANAGER" && e.JOB != "PRESIDENT")
            .ToList();

        Console.WriteLine("\n--- Übung 8: Job ist nicht Manager und President");
        PrintEmps(uebung8);
        
        var uebung9 = emps
            .Where(e => e.ENAME[3] == 'A')
            .ToList();

        Console.WriteLine("\n--- Übung 9: Alle Namen wo A an dritter Stelle steht");
        PrintEmps(uebung9);
        
        var uebung10 = emps
            .Where(e => e.COMM != null)
            .ToList();
        
        Console.WriteLine("\n--- Übung 10: Alle Mitarbeiter die Provision erhalten können ---");
        PrintEmps(uebung10);

        var uebung11 = emps
            .OrderBy(e => e.COMM)
            .GroupBy(e => e.DEPTID)
            .ToList();

        Console.WriteLine("\n--- Übung 11: Erstelle Mitarbeiterverzeichnis sortiert nach Provision ---");
        PrintEmps(uebung11);
        
        var uebung12 = emps
            .Where(e => e.JOB != "MANAGER" && e.JOB != "PRESIDENT")
            .OrderBy(e => e.DEPTID)        // Erst nach Abteilung
            .ThenBy(e => e.HIREDATE)       // Dann innerhalb der Abteilung nach Datum
            .GroupBy(e => e.DEPTID)
            .ToList();

        Console.WriteLine("\n--- Übung 12: Sortierte Mitarbeiter (keine Chefs) ---");
        PrintEmps(uebung12);

        var uebung13 = emps
            .Where(e => e.ENAME.Length == 6)
            .ToList();

        Console.WriteLine("\n--- Übung 13: Alle Mitarbeiter mit 6 Buchstaben im Namen ---");
        PrintEmps(uebung13);
        
        var uebung14 = emps
            .Where(e => e.DEPTID == 30)
            .Select(e => $"{e.ENAME} - {e.JOB}")
            .ToList();

        Console.WriteLine("\n--- Übung 14: Personal der Verkaufsfiliale ---");
        PrintEmps(uebung14);
        
        // var uebung15 
        // NVL(COMM, 0) + SAL wird dann bei null Werten nicht Gesamt null

        var uebung16 = emps
            .Select(e => new {
                e.ENAME,
                monthly = e.SAL,
                daily = Math.Round((decimal)(e.SAL / 22.0), 2),
                hourly = Math.Round((decimal)(e.SAL / 22.0 / 8.0), 2)
            })
            .ToList();

        Console.WriteLine("\n--- Übung 16: Gehaltsvariationen ---");
        PrintEmps(uebung16);

        var uebung17 = emps
            .Sum(e => e.SAL);

        Console.WriteLine("\n--- Übung 17: Gesamteinnahmen ---");
        Console.WriteLine(uebung17);

        var uebung18 = Math.Round(emps
            .Average(e => e.COMM ?? 250), 2);

        Console.WriteLine("\n--- Übung 18: Durchschnittliche Prämie bei null => 250 ---");
        Console.WriteLine(uebung18);

        var uebung19 = emps
            .Select(e => new
                {
                    e.ENAME,
                    e.DEPTID,
                    Gehalt = e.SAL >= 0,
                    Provision = e.COMM >= 0
                })
            .Where(e => e.DEPTID == 30)
            .ToList();

        Console.WriteLine("\n--- Übung 19: Wie viele Personen bekommen in Filiale 30 ein Gehalt und wie viele eine Provision ---");
        PrintEmps(uebung19);
        
        var uebung20 = emps
            .Select(e => e.JOB)
            .Distinct()
            .Count();

        Console.WriteLine("\n--- Übung 20: Anzahl verschiedener Jobs ---");
        Console.WriteLine(uebung20);
        
        var uebung21 = emps
            .Select(e => e.ParentID)
            .Where(e => e.HasValue)
            .Distinct()
            .ToList();

        Console.WriteLine("\n--- Übung 21: Alle Vorgesetzten distinct ---");
        PrintEmps(uebung21);

        var uebung22 = emps
            .Where(e => e.DEPTID == 30)
            .GroupBy(e => e.DEPTID)
            .Select(g => new
            {
                Filiale = g.Key,
                
                //SAL
                SumSAL = g.Sum(e => e.SAL ?? 0),
                CountSAL = g.Count(),
                AvgSAL = g.Average(e => e.SAL ?? 0),
                
                //COMM
                SumCOMM = g.Sum(e => e.COMM ?? 0),
                CountCOMM = g.Count(),
                AvgCOMM = g.Average(e => e.COMM ?? 0)
            })
            .ToList();

        Console.WriteLine("\n--- Übung 22: Gib Statistikdaten wie SUM, COUNT, AVG bezogen auf SAL und COMM aus wobei bei COMM statt null 0 gewertet werden soll ---");
        PrintEmps(uebung22);

        var uebung23 = emps
            .Where(e => e.JOB != "MANAGER" && e.JOB != "PRESIDENT")
            .GroupBy(e => e.DEPTID)
            .Select(g => new
            {
                Filiale = g.Key,
                AnzahlBerufe = g.Select(e => e.JOB)
                    .Distinct()
                    .Count()
            })
            .ToList();
        
        Console.WriteLine("\n--- Übung 23: Ermittlen Sie die Anzahl unterschiedlicher Berufe je Filiale, Manager und Präsident jedoch ausgenommen ---");
        PrintEmps(uebung23);



        var uebung24 = emps
            .GroupBy(e => e.DEPTID)
            .Select(g => new
            {
                Filiale = g.Key,
                AnzahlMitarbeiter = g.Count()
            })
            .Average(x => x.AnzahlMitarbeiter);

        Console.WriteLine("\n--- Übung 24: Ermittlen sie die durchschnittliche Anzahl Mitarbeiter je Filiale ---");
        Console.WriteLine(uebung24);
        
        
        
        var uebung25 = emps
            .Where(e => e.JOB == "MANAGER" || e.JOB == "PRESIDENT")
            .ToList();

        Console.WriteLine("\n--- Übung 25: Geben sie alle Führungskräfte aus (Manager und Präsident) ---");
        PrintEmps(uebung25);

        var uebung26 = emps
            .Where(e => (e.COMM ?? 0) > (e.SAL * 0.25))
            .Select(e => new
            {
                Name = e.ENAME,
                Job = e.JOB,
                COMM = e.COMM
            })
            .ToList();

        Console.WriteLine("\n--- Übung 26: Geben Sie Namen, JOB und Provision aller Angestellten aus, deren Provision größer als 25% des Gehalts ist. ---");
        PrintEmps(uebung26);

        var uebung27 = emps
            .Min(e => e.SAL + (e.COMM ?? 0));

        Console.WriteLine("\n--- Übung 27: Was ist das geringste Gehalt (SAL+COMM) ---");
        Console.WriteLine(uebung27);



        var uebung28 = emps
            .Min(e => e.HIREDATE);

        Console.WriteLine("\n--- Übung 28: Wann ist der älteste Mitarbeiter der Firma eingetreten? ---");
        Console.WriteLine(uebung28);

        var uebung29 = emps
            .GroupBy(e => new { e.DEPTID, e.JOB })
            .Select(g => new
            {
                Filiale = g.Key.DEPTID,
                Job = g.Key.JOB,
                Anzahl = g.Count()
            })
            .OrderBy(x => x.Filiale)
            .ThenBy(x => x.Job);

        Console.WriteLine("\n--- Übung 29: Ermittlen Sie je Filiale die in dieser ausgeübten JOBS sowie die Anzahl Personen, welche diesen in der jeweiligen Filiale ausüben ---");
        PrintEmps(uebung29);

        var highestIncomePerFiliale = emps
            .GroupBy(e => e.DEPTID)
            .Select(g => new
            {
                Filiale = g.Key,
                MaxEinkommen = g.Max(e => e.SAL + (e.COMM ?? 0))
            });

        var geringstesMaxEinkommen = highestIncomePerFiliale
            .Min(x => x.MaxEinkommen);
        
            
        Console.WriteLine("\n--- Übung 30: Ermittlen Sie je Filiale das höchste Einkommen und daraus (im Vergleich der einzelnen Filialen untereinander) den geringsten Betrag ---");
        PrintEmps(highestIncomePerFiliale);
        Console.WriteLine(geringstesMaxEinkommen);

        var uebung34 = emps
            .Where(e => e.DEPTID == 30)
            .GroupBy(e => e.DEPTID)
            .Select(g => new
            {
                Filiale = g.Key,

                // SAL (keine NULL-Probleme
                MinSAL = g.Min(e => e.SAL),
                MaxSAL = g.Max(e => e.SAL),
                AvgSAL = g.Average(e => e.SAL),
                CountSAL = g.Count(),

                // COMM (NULL ignorieren!)
                MinCOMM = g.Where(e => e.COMM.HasValue).Min(e => e.COMM),
                MaxCOMM = g.Where(e => e.COMM.HasValue).Max(e => e.COMM),
                AvgCOMM = g.Where(e => e.COMM.HasValue).Average(e => e.COMM),
                CountCOMM = g.Count(e => e.COMM.HasValue)

            })
            .FirstOrDefault();

        Console.WriteLine("\n--- Übung 34: Geben sie die Statistikdaten für Filiale 30 aus (MIN, MAX, AVG, COunt bezogen auf SAL sowie COMM), wobei NULL-Werte unberücksichtigt bleiben sollen ---");
        Console.WriteLine(uebung34);

        var uebung35 = emps
            .GroupBy(e => e.DEPTID)
            .Select(g => new
            {
                Filiale = g.Key,

                MinSAL = g.Min(e => e.SAL),
                MaxSAL = g.Max(e => e.SAL),
                AvgSAL = g.Average(e => e.SAL)
            })
            .ToList();

        Console.WriteLine("\n--- Übung 35: Ermittlen Sie Minimum, Maximum und Durchschnitt des Gehaltes je Filiale. ---");
        PrintEmps(uebung35);

        var uebung36 = emps
            .Where(e => e.JOB != "Manager" || e.JOB != "President")
            .GroupBy(e => e.DEPTID)
            .Select(g => new
            {
                Filiale = g.Key,

                MinSAL = g.Min(e => e.SAL),
                MaxSAL = g.Max(e => e.SAL),
                AvgSAL = g.Average(e => e.SAL),
                CountEMP = g.Count()
            })
            .ToList();

        Console.WriteLine("\n--- Übung 36: Ermittlen Sie Minimum, Maximum und Durchschnitt des Gehaltes sowie Anzahl der Mitarbeiter je Filiale, wobei jedoch Manager und Präsident nicht mitgerechnet werden sollen. ---");
        PrintEmps(uebung36);

        var uebung37 = emps
            .Where(e => e.COMM == null)
            .GroupBy(e => e.JOB)
            .Select(g => new
            {
                JOB = g.Key,

                AvgSal = g.Average(e => e.SAL)
            })
            .ToList();

        Console.WriteLine("\n--- Übung 37: Ermitteln Sie die Durchschnittsgehälter je JOB, wobei Personen mit Provisionszahlungen ausgenommen werden. ---");
        PrintEmps(uebung37);
        
        
        var uebung38 = emps
            .Where(e => e.SAL > 0)
            .GroupBy(e => e.DEPTID)
            .Select(g => new
            {
                Filiale = g.Key,
                
                MaxSal = g.Sum(e => (e.SAL + (e.COMM ?? 100))*12)
                
            })
            .ToList();


        Console.WriteLine("\n--- Übung 38: Ermitteln Sie die Gesamt-Jahreszahlung je Filiale (= SAL und COMM). Jene Mitarbeiter, bei denen keine Provision eingetragen ist, erhalten eine Ersatzzahlung in der Höhe von 100 US$/Monat. ---");
        PrintEmps(uebung38);

        /*var uebung40 = emps
            .Where(g => g.AvgSAL > 1500)
            .GroupBy(g => g.AvgSAL)
            .OrderBy(g => g.AvgSAL)
            .Select(g => new
            {
                Filiale = g.Key,

                AvgSAL = g.Average(e => e.SAL),
                Job = g.Key
            })
            .ToList();
        
        var uebung41 = emps */
            
    }


    public void Aufgaben2()
    {
        // Daten per StreamReader laden
        List<Dept> depts = LoadDepts(DeptPath);
        List<Emp> emps = LoadEmps(EmpPath);
        
        var u1 = emps
            .Where(e => e.JOB == "CLERK");

        PrintEmps(u1);

        var u2 = emps
            .OrderBy(e => e.ENAME);
        
        PrintEmps(u2);

        var u3 = emps
            .Max(e => e.SAL);

        Console.WriteLine(u3);

        var u4 = emps
            .GroupBy(e => e.JOB)
            .Select(g => new
            {
                JOB = g.Key,
                AvgSAL = g.Average(e => e.SAL)
            })
            .OrderBy(e => e.JOB);
        
        PrintEmps(u4);

        var u5 = emps
            .GroupBy(e => e.DEPTID)
            .Where(g => g.Count() > 3)
            .Select(g => new { DeptId = g.Key, Count = g.Count() });

        PrintEmps(u5);

        var u6 = emps
            .Where(e => e.JOB == "SALESMAN")
            .Select(g => new
            {
                Gesamt = g.SAL + g.COMM
            });

        PrintEmps(u6);

        var u7 = emps
            .GroupBy(e => e.DEPTID)
            .Select(d => new
            {
                Key = d.Key,
                Average = d.Average(e => e.SAL)
            })
            .Where(e => e.Key > e.Average);

        PrintEmps(u7);

        var a1 =
            from e in emps
            where e.JOB == "CLERK"
            select new { e.ENAME, e.SAL };
        
        foreach (var a in a1)
            Console.WriteLine(a.ToString());

        var a2 =
            from e in emps
            orderby e.ENAME
            select new { e.ENAME, e.SAL };
        
        foreach (var a in a2)
            Console.WriteLine(a.ToString());
        
        var a3 = 
            from e in emps
            where e.DEPTID == 20 && e.SAL > 1000
            select new { e.ENAME, e.SAL };
        
        foreach (var a in a3)
            Console.WriteLine(a.ToString());

        var a4 =
            from e in emps
            group e by e.JOB into g
            orderby g.Key
            select new
            {
                JOB = g.Key,
                avgSal = g.Average(e => e.SAL)
            };
        
        foreach (var a in a4)
            Console.WriteLine(a.ToString());

        var a5 =
            from e in emps
            where e.JOB == "SALESMAN"
            let totalSal = e.SAL + (e.COMM ?? 0)
            orderby totalSal descending
            select new
            {
                e.ENAME,
                Total = totalSal
            };
        
        foreach (var a in a5)
            Console.WriteLine(a.ToString());
        
        
        var a6 = 

    }



    // --- STREAMREADER METHODEN ---

    private List<Dept> LoadDepts(string path)
    {
        var list = new List<Dept>();
        if (!File.Exists(path)) return list;

        using var reader = new StreamReader(path);
        while (reader.ReadLine() is { } line)
        {
            var parts = line.Split(','); // Annahme: Trennung durch Semikolon
            if (parts.Length >= 3)
            {
                list.Add(new Dept { 
                    DEPTNO = int.Parse(parts[0]), 
                    DNAME = parts[1], 
                    LOC = parts[2] 
                });
            }
        }
        return list;
    }

    private List<Emp> LoadEmps(string path)
    {
        var list = new List<Emp>();
        if (!File.Exists(path)) return list;

        using var reader = new StreamReader(path);
        while (reader.ReadLine() is { } line)
        {
            // Falls die Datei eine Kopfzeile hat (z.B. "ID,ENAME..."), aktiviere das nächste if:
            // if (line.StartsWith("ID") || string.IsNullOrWhiteSpace(line)) continue;

            var p = line.Split(',');
        
            // Debug-Tipp: Wenn es wieder kracht, schalte diese Zeile ein, um zu sehen was in p[3] steht:
            // Console.WriteLine($"Debug: Versuche '{p[3]}' als Datum zu parsen");

            if (p.Length >= 7) // Sicherstellen, dass genug Spalten da sind
            {
                try 
                {
                    list.Add(new Emp {
                        ID = int.Parse(p[0].Trim()),
                        ENAME = p[1].Trim(),
                        JOB = p[2].Trim(),
                        // Falls '7902' in p[3] stand, ist das Datum vermutlich in p[4] oder p[5]!
                        // Passe den Index [X] hier an die tatsächliche Position in deiner Datei an:
                        HIREDATE = DateOnly.Parse(p[4].Trim()), 
                        SAL = int.Parse(p[5].Trim()),
                        // Sicherer Umgang mit leeren/null Provisionen
                        COMM = (p.Length > 6 && int.TryParse(p[6], out int commVal)) ? commVal : null,
                        DEPTID = int.Parse(p[p.Length - 1].Trim()) // Meistens die letzte Spalte
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fehler in Zeile: {line}");
                    Console.WriteLine($"Details: {ex.Message}");
                }
            }
        }
        return list;
    }

    public static void PrintEmps<T>(IEnumerable<T> liste)
    {
        if (liste == null || !liste.Any()) return;

        foreach (var element in liste)
        {
            // 1. Fall: Es ist eine Gruppierung (wie Übung 12)
            if (element is System.Collections.IEnumerable gruppe && element is not string)
            {
                // Wir nutzen Reflection, um den Key der Gruppe zu finden
                var keyProp = element.GetType().GetProperty("Key");
                Console.WriteLine($"\n=== Gruppe: {keyProp?.GetValue(element)} ===");

                foreach (var subItem in gruppe)
                {
                    Console.WriteLine($"   {subItem}");
                }
            }
            // 2. Fall: Es ist ein einzelnes Objekt oder ein anonymer Typ aus .Select()
            else
            {
                Console.WriteLine(element?.ToString());
            }
        }
    }
}