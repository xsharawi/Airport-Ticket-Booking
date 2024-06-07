public class Flight
{
    public int Price { get; set; }
    public string Departure_Country { get; set; }
    public string Destination_Country { get; set; }
    public DateTime Departure_Date { get; set; }
    public DateTime Departure_Airport { get; set; }
    public string Arrival_Airport { get; set; }
    public string Class { get; set; }

    public Flight(int price, string destination_Country, string departure_Country, DateTime departure_Date, DateTime departure_Airport, string arrival_Airport, string @class)
    {
        Price = price;
        Destination_Country = destination_Country;
        Departure_Country = departure_Country;
        Departure_Date = departure_Date;
        Departure_Airport = departure_Airport;
        Arrival_Airport = arrival_Airport;
        Class = @class;
    }

}

public class Passenger
{
    public int PassengerId { get; set; }
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
