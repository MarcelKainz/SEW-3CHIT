using System.Collections;

namespace ScottQueries;

public class Department : IEnumerable
{
    public Department(int deptNo, string dname, string loc)
    {
        this.DeptNO = deptNo;
        this.DNAME = dname;
        this.LOC = loc;
    }

    public Department()
    {
        
    }

    public int DeptNO { get; set; }
    public string DNAME { get; set; }
    public string LOC { get; set; }
    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }

}