namespace ScottQueries;

class Program
{
    public static void Main()
    {
        // 1. Listen initialisieren und aus Dateien laden
        var depts = new DepartmentList();
        var emps = new EmployeeList();

        // Achte darauf, dass die Dateien im Ausgabeverzeichnis liegen
        // oder gib den vollen Pfad an
        try {
            depts.Load(@"C:\\Users\\kainz\\RiderProjects\\3CHIT_SEW_2\\LinQ\\Departments.txt");
            emps.Load(@"C:\\Users\\kainz\\RiderProjects\\3CHIT_SEW_2\\LinQ\\Employees.txt");
        } catch (Exception ex) {
            Console.WriteLine("Fehler beim Laden: " + ex.Message);
        }

        // 1. SELECT * FROM depts
        var res1 = from d in depts select d;

        // 2. ename, job, HIREDATE FROM emps WHERE dept_id = 10
        var res2 = from e in emps 
                   where e.dept_id == 10 
                   select new { e.ENAME, e.JOB, e.HIREDATE };

        // 3. ename, job, SAL FROM emps
        var res3 = from e in emps select new { e.ENAME, e.JOB, e.SAL };

        // 4. SELECT * FROM emps WHERE dept_id != 10
        var res4 = from e in emps where e.dept_id != 10 select e;

        // 5. SELECT * FROM emps WHERE COMM > SAL
        var res5 = from e in emps where e.COMM > e.SAL select e;

        // 6. SELECT * FROM emps WHERE HIREDATE = '03.12.1981'
        var res6 = from e in emps 
                   where e.HIREDATE == new DateTime(1981, 12, 3) 
                   select e;

        // 7. ename, Sal FROM emps WHERE SAL < 1250 AND SAL > 1600 (Leer)
        var res7 = from e in emps 
                   where e.SAL < 1250 && e.SAL > 1600 
                   select new { e.ENAME, e.SAL };

        // 8. JOB != 'MANAGER' AND JOB != 'PRESIDENT' (Logik korrigiert auf AND)
        var res8 = from e in emps 
                   where e.JOB.ToUpper() != "MANAGER" && e.JOB.ToUpper() != "PRESIDENT" 
                   select e;

        // 9. ENAME LIKE '__A%' (A an dritter Stelle)
        var res9 = from e in emps 
                   where e.ENAME.Length >= 3 && e.ENAME.ToUpper()[2] == 'A' 
                   select e;

        // 10. ID, ENAME, JOB FROM emps WHERE COMM IS NOT NULL AND COMM != 0
        var res10 = from e in emps 
                    where e.COMM != 0 
                    select new { e.ID, e.ENAME, e.JOB };
        
        

        MyExtension mye = new MyExtension();


        Console.WriteLine(mye.PrinttoConsole($"res1: {res1.ToString()}"));
        Console.WriteLine(mye.PrinttoConsole($"res2: {res2.ToString()}"));
        Console.WriteLine(mye.PrinttoConsole($"res3: {res3.ToString()}"));
        Console.WriteLine(mye.PrinttoConsole($"res4: {res4.ToString()}"));
        Console.WriteLine(mye.PrinttoConsole($"res5: {res5.ToString()}"));
        Console.WriteLine(mye.PrinttoConsole($"res6: {res6.ToString()}"));
        Console.WriteLine(mye.PrinttoConsole($"res7: {res7.ToString()}"));
        Console.WriteLine(mye.PrinttoConsole($"res8: {res8.ToString()}"));
        Console.WriteLine(mye.PrinttoConsole($"res9: {res9.ToString()}"));
        Console.WriteLine(mye.PrinttoConsole($"res10: {res10.ToString()}"));

        // --- TEST AUSGABE (Beispiel Aufgabe 9) ---
        Console.WriteLine("Ergebnis Aufgabe 9 (Name mit 'A' an 3. Stelle):");
        foreach (var x in res9) 
            Console.WriteLine($"{x.ID}: {x.ENAME}");
    }

}