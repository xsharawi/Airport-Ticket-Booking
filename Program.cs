using CsvHelper;

List<Flight> AllFlights = new();

void MainMenu()
{
    Console.WriteLine("Welcome to the Flight Booking Application");
    Console.WriteLine("1- Passenger");
    Console.WriteLine("2- Manager");
    Console.WriteLine("3- Exit");
}

void ManagerMenu()
{
    Console.Clear();
    Console.WriteLine("1- Filter bookings");
    Console.WriteLine("2- Upload Flights from CSV");
    Console.WriteLine("3- Validate input CSV info");
    Console.WriteLine("4- Validate input CSV info");
    Console.WriteLine("5- Exit");
}

void PassengerMenu()
{
    Console.Clear();
    Console.WriteLine("1- Book a flight");
    Console.WriteLine("2- Search avaliable flights");
    Console.WriteLine("3- Manage your bookings");
    Console.WriteLine("4- Exit");
}

List<Flight> SearchFlights()
{

    List<Flight> FoundFlights = new();

    Console.WriteLine("Flight Price?");
    var Price = Console.ReadLine();
    if (Price == null) Price = "";
    int price = int.Parse(Price);
    var Booked = false;
    Console.WriteLine("Flight Departure Country?");
    var Departure_Country = Console.ReadLine();
    Console.WriteLine("Flight Destination Country?");
    var Destination_Country = Console.ReadLine();
    Console.WriteLine("Flight Departure Date?");
    var Departure_Date = Console.ReadLine();
    Console.WriteLine("Flight Departure Airport?");
    var Departure_Airport = Console.ReadLine();
    Console.WriteLine("Flight Arrival Airport?");
    var Arrival_Airport = Console.ReadLine();
    Console.WriteLine("Flight Class? (Economy, Business, FirstClass)");
    var Flight_Class = Console.ReadLine();
    Class? @class = null;
    DateTime FindTime = DateTime.Parse(Departure_Date);
    if (Flight_Class == "Economy")
    {
        @class = Class.Economy;
    }
    else if (Flight_Class == "Business")
    {
        @class = Class.Business;
    }
    else if (Flight_Class == "FirstClass")
    {
        @class = Class.FirstClass;
    }

    FoundFlights = AllFlights.Where(flight => (flight.Price == price) && (flight.Booked == Booked) && (flight.Departure_Country == Departure_Country)
            && (flight.Destination_Country == Destination_Country) && (flight.Departure_Airport == Departure_Airport) && (flight.Arrival_Airport == Arrival_Airport) && (flight.FlightClass == @class) && (flight.Departure_Date == FindTime)
            ).ToList();

    return FoundFlights;

}

while (true)
{
    int FirstAction = -1;
    MainMenu();
    try
    {
        FirstAction = int.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        if (e is FormatException)
        {
            Console.WriteLine("Please enter a valid number");
            continue;
        }
    }

    if (FirstAction == 1)
    {
        PassengerMenu();
    }
    else if (FirstAction == 2)
    {
        ManagerMenu();
    }
    else
    {
        Console.WriteLine("Please enter a valid number");
        continue;
    }



}



