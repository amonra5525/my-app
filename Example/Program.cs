public class Legkovoicar
{
    public int Ocenka = 2;
}

public class Velosiped
{
    public int Ocenka = 1;
}

public class Sportcar
{
    public int Ocenka = 4;
}

static class Sravnenie
{
    public static void Kel(Legkovoicar car, Velosiped bike, Sportcar scar)
    {
        if (car.Ocenka < 3)
            Console.WriteLine("Хуйня");
        if (bike.Ocenka < 3)
            Console.WriteLine("Хуйня");
        if (scar.Ocenka < 3)
            Console.WriteLine("Хуйня");
        else Console.WriteLine("Заебись");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Legkovoicar car = new Legkovoicar();
        Velosiped ped = new Velosiped();
        Sportcar scar = new Sportcar();
        Sravnenie.Kel(car, ped, scar);
    }
}