using System.Collections;
namespace IteratorTrain;

public class WagonIterator(Wagon _first) :IEnumerator
{
    private Wagon _current;

    /*public WagonIterator(Wagon first)
    {
        _first = first;
    }*/
    
    public bool MoveNext()
    {
        _current = _current==null ? _first:_current.Next; // so wie if 
        return _current!=null;
    }

    public void Reset() => throw new NotImplementedException();

    public object? Current => _current;
}