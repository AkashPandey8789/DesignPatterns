public interface ISubject
{
    void NotifyObserver();
    void RegisterObserver(Observer o);
}

public class Observer
{
    private ISubject _subject;
    public Observer(ISubject subject, String Name)
    {
        _subject = subject;
        this.Name = Name;
    }
    public string Name { get; set; }

    public void NotifyMe()
    {
        _subject.RegisterObserver(this);
    }

    public void Update(string message)
    {
        Console.WriteLine(message);
    }

}

public class Subject : ISubject
{
    public List<Observer> observers;

    public Subject()
    {
        observers = new List<Observer>();
    }

    public void RegisterObserver(Observer o)
    {
        observers.Add(o);
    }
    public void NotifyObserver()
    {
        foreach(Observer o in observers)
        {
            o.Update($"Dear {o.Name} Product back in stock ");
        }
    }
}