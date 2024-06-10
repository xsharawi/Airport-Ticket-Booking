public enum Class
{
    Economy,
    Business,
    FirstClass
}

public class Flight
{
    public int Id { get; set; }
    public int Price { get; set; }
    public bool Booked { get; set; }
    public string Departure_Country { get; set; }
    public string Destination_Country { get; set; }
    public DateTime Departure_Date { get; set; }
    public string Departure_Airport { get; set; }
    public string Arrival_Airport { get; set; }
    public Class FlightClass { get; set; }

    public Flight(int price, string destination_Country, string departure_Country, DateTime departure_Date, string departure_Airport, string arrival_Airport, string @class, bool booked, int id, Class flightClass)
    {
        Price = price;
        Destination_Country = destination_Country;
        Departure_Country = departure_Country;
        Departure_Date = departure_Date;
        Departure_Airport = departure_Airport;
        Arrival_Airport = arrival_Airport;
        Booked = booked;
        Id = id;
        FlightClass = flightClass;
    }

}

