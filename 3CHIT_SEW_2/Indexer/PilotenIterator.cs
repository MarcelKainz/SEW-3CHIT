using System.Collections;

namespace Indexer;

public class PilotenIterator:IEnumerator
{
    int _current_position = -1;
    //private Person[] _data;
    private Formel1Piloten _data; // besser ?

    public PilotenIterator(Formel1Piloten data)
    {
        _data = data;
    }
    
    public bool MoveNext()
    {
        //_current_position++;
        // bewegt sich weiter, zum nächsten nicht-leeren Element
        while (_current_position < _data.Lenght && (_data[_current_position] != null))
            _current_position++;
        return _current_position < _data.Lenght;
    }

    public void Reset()
    {
        //_current_position = -1;
        throw new NotImplementedException();
    }

    public object? Current
    {
        get
        {
            return _data[_current_position];
        }
    }
}