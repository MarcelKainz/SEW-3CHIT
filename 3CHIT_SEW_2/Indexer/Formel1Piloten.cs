using System.Collections;
using System.Text;

namespace Indexer;

public class Formel1Piloten : IEnumerable
{
    private const int MAX_PILOTS = 99;
    private Person[] _piloten = new Person[99];

    public Person this[int i]
    {
        // check auf 1-99 fehlt
        
        //beginnt bei 1
        get { return _piloten[i];}
        set{_piloten[i-1] = value;} 
    }

    public int Lenght
    {
        get { return _piloten.Length; }
    }

    public Person this[string s]
    {
        get
        {
            for (int i = 0; i < MAX_PILOTS; i++)
            {
                if(_piloten[i] != null)
                    if (_piloten[i].ToString() == s)
                        return _piloten[i];
            }
            return null;
        }
        set
        {
            for (int i = 0; i < MAX_PILOTS; i++)
            {
                if (_piloten[i] == null)
                {
                    _piloten[i] = value;
                    return;
                }
            }
        }
    }

    override public string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < MAX_PILOTS; i++)
        {
            sb.Append($"{i + 1}. {_piloten[i]}\n");
        }
        return sb.ToString();
    }

    public IEnumerator GetEnumerator()
    {
        //return _piloten.GetEnumerator();
        return new PilotenIterator(this);
    }
}

