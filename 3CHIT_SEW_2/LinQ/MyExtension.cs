namespace ScottQueries;

public class MyExtension
{
    public static string PrinttoConsole(Employee e)
    {
        foreach (var x in e)
        {
        }
        return $"ID: {e.ID} | " +
               $"Name: {e.ENAME} | " +
               $"Job: {e.JOB} | " +
               $"Salary: {e.SAL} | " +
               $"HireDate: {e.HIREDATE.ToShortDateString()} | " +
               $"Comm: {e.COMM} | " +
               $"ParentID: {e.parent_id} | " +
               $"DeptID: {e.dept_id}";
    }
    
    public static string PrinttoConsole(Department d)
    {
        return $"DeptNO: {d.DeptNO} | " +
               $"DNAME: {d.DNAME} | " +
               $"LOC: {d.LOC}";
    }

    // NEU: Für die gesamte DepartmentList
    public static string GetFullListString(DepartmentList list)
    {
        string result = "";
        foreach (var d in list)
        {
            //result += d.PrinttoConsole() + "\n";
        }
        return result;
    }

    public string PrinttoConsole(IEnumerable<Department> res) {
        foreach (var x in res) {
            return x.ToString(); // Hier bricht die Methode nach dem ersten Element ab!
        }
        return res.ToString();
    }

    public string PrinttoConsole(IEnumerable<Employee> res)
    {
        foreach (var x in res)
        {
            return x.ToString();
        }

        return res.ToString();
    }

    public string PrinttoConsole(MyExtension res)
    {
        Console.WriteLine("--- MyExtension PrinttoConsole ---");
        return res.ToString();
    }

    public string PrinttoConsole(object res2)
    {
        return res2.ToString();
    }
}