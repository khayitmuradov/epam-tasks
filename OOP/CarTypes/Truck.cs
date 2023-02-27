using OOP.Entities;

namespace OOP.CarTypes;
public class Truck
{
    public Engine Engine = new Engine()
    {
        Power = 450,
        Volume = 14553,
        Type = "V8",
        SerialNumber = "JH4KA3250LC002400"
    };
    public Chassis Chassis = new Chassis()
    {
        WheelsNumber = 4,
        Number = "1B7GG23Y1NS526835",
        PermissibleLoad = 4500
    };
    public Transmission Transmission = new Transmission()
    {
        Type = "Manual",
        NumberOfGears = 4,
        Manufacturer = "Ford F-150"
    };

    public void Info()
    {
        Console.WriteLine("Truck Informations: \nEngine");
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
