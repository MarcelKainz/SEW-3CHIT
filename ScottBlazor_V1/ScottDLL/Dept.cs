using System.ComponentModel.DataAnnotations;

namespace DBScott;

public class Dept
{
    [Required]
    public int DEPTNO { get; set; }
    [Required]
    public string DNAME { get; set; }
    public string LOC { get; set; }
}