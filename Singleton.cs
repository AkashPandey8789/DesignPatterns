public sealed class Singleton
{
    // private static Singleton _singleton;

    // private static readonly object InstanceLock = new object();

    private static Lazy<Singleton> singleton = new Lazy<Singleton>(() => new Singleton());
    private static int counter = 0;

    private Singleton()
    {
        counter++;
        Console.WriteLine($"{counter}");
    }

    public static Singleton GetInstance()
    {
        return singleton.Value;
    }
    // public static Singleton GetInstance()
    // {
    //     if (_singleton == null) //this check will allow multi-threading once the instance is created by any one thread...
    //     {
    //         lock (InstanceLock) //this slows the system as only one thread can access the instance at once....
    //         {
    //             if (_singleton == null)  // if the instance is not created we are checking just to be safe in meantime no other thread created instance
    //             {
    //                 _singleton = new Singleton();
    //                 //return new Singleton();
    //             }
    //         }
    //     }
    //     return _singleton;
    // }

    public void Print(string message)
    {
        Console.WriteLine($"{message}");
    }
}