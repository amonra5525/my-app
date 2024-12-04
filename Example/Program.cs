public class Transport
{
    public string Ocenka;
}

public class Passengercar : Transport
{
    public int Ocenka = 2;
}

public class Bicycle : Transport
{
    public int Ocenka = 1;
}

public class Sportcar : Transport
{
    public int Ocenka = 4;
}

static class Sravnenie
{
    public static void Kel(Transport)
    {
        switch (Transport.Ocenka)
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
    static void Main(string[] args)
    {
        Passengercar car = new Passengercar();
        Bicycle ped = new Bicycle();
        Sportcar scar = new Sportcar();
        Sravnenie.Kel(car, ped, scar);
    }
}