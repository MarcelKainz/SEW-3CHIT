using System.Collections;
using System.Text;
namespace IteratorTrain;

class Train:IEnumerable
{
    public Wagon first;
    
    public void Add(Wagon toAdd)
    {
        //fügt vorne einen neuen Waggon hinzu
        toAdd.Next = first;
        first = toAdd;
    }


    public Wagon ? this[int i]
    {
        //HÜ
        get
        {
            Wagon current = first;
            int index = 0;

            while (current != null)
            {
                if (index == i)
                    return current;
                current = current.Next;
                index++;
            }

            return null; 
        }
    }

    override public string ToString()
    {
        Wagon temp=first;
        StringBuilder sb = new StringBuilder();
        
        while (temp != null)
        {
            Console.WriteLine(temp);
            temp = temp.Next;
        }
        return sb.ToString();
    }

    public IEnumerator GetEnumerator()
    {
        return new WagonIterator(this.first);
    }
}