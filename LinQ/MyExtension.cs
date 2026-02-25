using ScottQueries;

public static class MyExtension
{
    public static string PrinttoConsole(this Employee e)
    {
        return $"ID: {e.ID} | " +
               $"Name: {e.ENAME} | " +
               $"Job: {e.JOB} | " +
               $"Salary: {e.SAL} | " +
               $"HireDate: {e.HIREDATE.ToShortDateString()} | " +
               $"Comm: {e.COMM} | " +
               $"ParentID: {e.parent_id} | " +
               $"DeptID: {e.dept_id}";
    }
    
    public static string PrinttoConsole(this Department d)
    {
        return $"DeptNO: {d.DeptNO} | " +
               $"DNAME: {d.DNAME} | " +
               $"LOC: {d.LOC}";
    }
}