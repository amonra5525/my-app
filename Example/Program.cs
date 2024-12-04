public class Transport
{
    public string Ocenka; // почему на русском епта
}

public class Passengercar : Transport
{
    public int Ocenka = 2; // зачем свойство тут если оно есть сверху, райдер сам желтым подсвечивает 
}

public class Bicycle : Transport
{
    public int Ocenka = 4;
}

public class Sportcar : Transport
{
    public int Ocenka = 4;
}

static class Sravnenie // опять по русски
{
    // что значит kel? норм название
    public static void Kel(Transport) // а хули transport
    {
        switch (Transport.Ocenka) // вызываешь свойство у типа а не у экземпляра
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
        Passengercar car = new Passengercar();
        Bicycle ped = new Bicycle();
        Sportcar scar = new Sportcar();
        // оставь в методе Transport но передавай теперь правильно тут
        // вызови несколько раз и передай другие классы ниже
        Sravnenie.Kel(car, ped, scar);
    }
}