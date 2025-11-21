namespace MyList;


public class MyElement
{
    public MyElement Next { get; set; }
    public int Value { get; set; }
        
        
    public override string ToString()
    {
        return Next == null ? Value + "(null)":
        Value + "->" + Next.ToString();
    }
}