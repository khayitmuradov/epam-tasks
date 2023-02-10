

using OOP.CarTypes;

namespace OOP;

public class Program
{
    public static void Main()
    {
        OutputInfo();
    }

    public static void OutputInfo()
    {
        PassengerCar passengerCar = new PassengerCar();
        passengerCar.Info();

        Console.WriteLine();
        Console.WriteLine();

        Truck truck = new Truck();
        truck.Info();

        Console.WriteLine();
        Console.WriteLine();

        Bus bus = new Bus();
        bus.Info();

        Console.WriteLine();
        Console.WriteLine();

        Scooter scooter = new Scooter();
        scooter.Info();
    }
}