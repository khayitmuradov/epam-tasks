using OOP.Entities;

namespace OOP.CarTypes;

public class PassengerCar
{
    public Engine Engine = new Engine()
    {
        Power = 690,
        Volume = 6498,
        Type = "Hybrid",
        SerialNumber = "JH4DB1542MS007683"
    };
    public Chassis Chassis = new Chassis()
    {
        WheelsNumber = 4,
        Number = "2S3TD52V3Y6103456",
        PermissibleLoad = 2200
    };
    public Transmission Transmission = new Transmission()
    {
        Type = "Automatic",
        NumberOfGears = 4,
        Manufacturer = "Lamborghini"
    };

    public void Info()
    {
        Console.WriteLine("Passenger Car Informations: \nEngine");
        Console.WriteLine($"Power: {Engine.Power}");
        Console.WriteLine($"Volume: {Engine.Volume}");
        Console.WriteLine($"Type: {Engine.Type}");
        Console.WriteLine($"Serial Number: {Engine.SerialNumber}");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Chassis");
        Console.WriteLine($"Wheels Number: {Chassis.WheelsNumber}");
        Console.WriteLine($"Number: {Chassis.Number}");
        Console.WriteLine($"Load: {Chassis.PermissibleLoad}");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Transmission");
        Console.WriteLine($"Type: {Transmission.Type}");
        Console.WriteLine($"Number Of Gears: {Transmission.NumberOfGears}");
        Console.WriteLine($"Manufacturer: {Transmission.Manufacturer}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine();
    }
}
