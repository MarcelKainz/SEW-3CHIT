namespace ScottQueries;

public class EmployeeList:List<Employee>
{
    public void Load(string filename)
    {
        // LÖSCHE die Zeile: filename = @"Employees.txt"; <-- Sonst wird dein Pfad aus der Main ignoriert!
        using var reader = new StreamReader(filename);
        string line;
        while ((line = reader.ReadLine()) != null) // Die ganze Zeile lesen!
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            var elements = line.Split(',');
        
            this.Add(new Employee()
            {
                ID = Convert.ToInt32(elements[0]),
                ENAME = elements[1],
                JOB = elements[2],
                parent_id = string.IsNullOrEmpty(elements[3]) ? 0 : Convert.ToInt32(elements[3]),
                HIREDATE = Convert.ToDateTime(elements[4]),
                SAL = Convert.ToInt32(elements[5]),
                COMM = string.IsNullOrEmpty(elements[6]) ? 0 : Convert.ToInt32(elements[6]),
                dept_id = Convert.ToInt32(elements[7])
            });
        }
    }
    
}