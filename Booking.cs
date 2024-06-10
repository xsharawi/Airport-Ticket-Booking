
public class Passenger
{
    public int PassengerId { get; set; }
    public string PassengerName { get; set; } = "";
}

public class Booking
{
    public Flight Flight { get; set; }
    public Passenger Passenger { get; set; }
    public bool isActive { get; set; } = false;

    public Booking(Flight flight, Passenger passenger)
    {
        Flight = flight;
        Passenger = passenger;
    }

}
