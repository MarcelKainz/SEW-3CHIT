namespace Whatisvar;

class Program
{
    static void Main(string[] args)
    {
        int y = 7; // y is explizit datatype int
        var x = 7; // x is implizit datatype int
        
        // y = "egal"; // can never work
        // x = "egal"; // can never work (same!) [in JS this works !! ;( ]
    }
}