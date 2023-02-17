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
        Truck truck = new Truck();
        Bus bus = new Bus();
        Scooter scooter = new Scooter();

        passengerCar.Info();
        truck.Info();
        bus.Info();
        scooter.Info();
    }
}