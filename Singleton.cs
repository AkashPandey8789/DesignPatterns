public sealed class Singleton
{
    private static Singleton _singleton;

    private static readonly object InstanceLock = new object();
    private static int counter = 0;

    private Singleton()
    {
        counter++;
        Console.WriteLine($"{counter}");
    }

    public static Singleton GetInstance()
    {
        lock(InstanceLock)
        {
            if (_singleton == null)
            {
                _singleton = new Singleton();
                //return new Singleton();
            }
        }
        return _singleton;
    }
    
    public void Print(string message)
    {
        Console.WriteLine($"{message}");
    }
}