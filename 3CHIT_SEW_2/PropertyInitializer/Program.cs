Coords point = new Coords(); // empty constructor (always) exists
point.x = 3; //Init Code
point.y = 4; //Init Code


Coords pt = new Coords{x=3, y=4}; //quasi empty constructor + Init Code

class Coords
{
    public int x { get; set; }
    public int y { get; set; }
    
    
}