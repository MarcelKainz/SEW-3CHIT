namespace Singleton;

public sealed class Singleton_2
{
    private static Singleton_2 instance=null;
    private Singleton_2()
    {
    }

    public static Singleton_2 GetInstance()
    {
    if (instance == null)
    {
        instance = new Singleton_2();
    }
    return instance;
    }
}
//