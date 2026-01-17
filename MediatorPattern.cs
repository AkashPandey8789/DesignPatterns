public interface ITaxiDispatcher
{
    void NotifyRideAcceptanceRequestToDriver(Passenger passenger, string destination);
    void NotifyRideAcceptanceRequestToPassenger(Passenger passenger, Driver driver, string destination);
}

public class TaxiDispatcher : ITaxiDispatcher
{
    Dictionary<string, string> driverDestination = new Dictionary<string, string>();
    //waiting list can be added.. didn't add just to not over complicate
    HashSet<string> destinations = new HashSet<string>();
    public TaxiDispatcher()
    {
        driverDestination["Ram"] = "Ayodhya";
        destinations.Add("Ayodhya");
        driverDestination["Shyam"] = "Mathura";
        destinations.Add("Mathura");
    
    }
    public void NotifyRideAcceptanceRequestToDriver(Passenger passenger, string destination)
    {
        if (destinations.Contains(destination))
        {
            string driver = driverDestination.Keys.Where(k => driverDestination[k] == destination).FirstOrDefault();
            if (!string.IsNullOrEmpty(driver))
            {
                new Driver(driver, destination, this).RideAccepte(passenger);
            }
        }
    }
    
    public void NotifyRideAcceptanceRequestToPassenger(Passenger passenger, Driver driver, string Destination)
    {
        Console.WriteLine("Ride Accepted notifiying passenger");
        driverDestination.Remove(driver.Name);
    }
}

public class Passenger
{
    public string Name { get; set; }

    public string Destination { get; set; }

    public Passenger(string Name, string Destination, ITaxiDispatcher taxiDispatcher)
    {
        this.Name = Name;
        this.Destination = Destination;
        _taxiDispatcher = taxiDispatcher;
    }

    private readonly ITaxiDispatcher _taxiDispatcher;

    public void RideRequest()
    {
        Console.WriteLine($"Requesting for ride by {this.Name} to {this.Destination}");
        _taxiDispatcher.NotifyRideAcceptanceRequestToDriver(this, Destination);
    }
}

public class Driver
{
    public string Name { get; set; }
    public string Destination { get; set; }

    public Driver(string Name, string Destination, ITaxiDispatcher taxiDispatcher)
    {
        this.Name = Name;
        this.Destination = Destination;
        _taxiDispatcher = taxiDispatcher;
    }
    private readonly ITaxiDispatcher _taxiDispatcher;

    public void RideAccepte(Passenger passenger)
    {
        Console.WriteLine($"Accepting ride requested by {passenger.Name} , driver name - {this.Name} to destination - {this.Destination}");
        _taxiDispatcher.NotifyRideAcceptanceRequestToPassenger(passenger, this, Destination);
    }
}