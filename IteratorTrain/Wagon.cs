using System.Text;
namespace IteratorTrain;

public class Wagon
{
    public int Capacity {get; set;}
    public string Color {get; set;}
    
    public Wagon Next {get; set;}

    override public string ToString()
    {
        return $"Wagon: {Capacity }Seats, {Color}";
    }
}