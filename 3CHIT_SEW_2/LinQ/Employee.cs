using System.Collections;

namespace ScottQueries;

public class Employee : IEnumerable
{
    public Employee(int ID, string ENAME, string JOB, int parent_id, DateTime HIREDATE, int SAL, int COMM, int dept_id)
    {
        this.ID = ID;
        this.ENAME = ENAME;
        this.JOB = JOB;
        this.parent_id = parent_id;
        this.HIREDATE = HIREDATE;
        this.SAL = SAL;
        this.COMM = COMM;
        this.dept_id = dept_id;

    }

    public Employee()
    {
        
    }


    public int ID { get; set; }
    public string ENAME { get; set; }
    public string JOB { get; set; }
    public int parent_id { get; set; }
    public DateTime HIREDATE { get; set; }
    public int SAL { get; set; }
    public int COMM { get; set; }
    public int dept_id { get; set; }
    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}