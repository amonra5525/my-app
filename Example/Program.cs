public class Transport
{
    public int Rating { get; set; }                           
}

public class Passengercar : Transport
{
                                                    
}

public class Bicycle : Transport
{

}

public class Sportcar : Transport
{
    
}

static class Compare                                    
{
                                                      
    public static void CheckRating (Transport transport)                   
    {
        switch (transport.Rating)                           
        {
            case < 3:
                Console.WriteLine("Хуйня");
                break;
            default:
                Console.WriteLine("Заебись");
                break;
        }
    }
}

class Program
{
    static void Main()
    {
        Passengercar car = new Passengercar {Rating = 3};
        Bicycle bicycle = new Bicycle   {Rating = 1};
        Sportcar scar = new Sportcar  {Rating = 5};
        Compare.CheckRating(bicycle);
        Compare.CheckRating(car);
        Compare.CheckRating(scar);
    }
}