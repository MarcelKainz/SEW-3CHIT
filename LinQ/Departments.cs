namespace ScottQueries;

public class DepartmentList:List<Department>
{
    public void Load(string filename)
    {
        // LÖSCHE die Zeile: filename = @"Departments.txt";
        using var reader = new StreamReader(filename);
        string line;
        while ((line = reader.ReadLine()) != null) // Die ganze Zeile lesen!
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            var elements = line.Split(',');
        
            this.Add(new Department()
            {
                DeptNO = Convert.ToInt32(elements[0]),
                DNAME = elements[1],
                LOC = elements[2]
            });
        }
    }
}