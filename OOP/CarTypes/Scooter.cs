using OOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CarTypes;

public class Scooter
{
    public Scooter()
    {
    }

    public Scooter(Engine engine, Chassis chassis, Transmission transmission)
    {
        Engine = engine;
        Chassis = chassis;
        Transmission = transmission;
    }

    public Engine Engine = new Engine()
    {
        Power = 240,
        Volume = 1400,
        Type = "Automatic",
        SerialNumber = "JH4CC2560PC005719"
    };
    public Chassis Chassis = new Chassis()
    {
        WheelsNumber = 2,
        Number = "WBAWC73578E067076",
        PermissibleLoad = 350
    };
    public Transmission Transmission = new Transmission()
    {
        Type = "Automatic",
        NumberOfGears = 1,
        Manufacturer = "Super Simple"
    };

    public void Info()
    {
        Console.WriteLine("Scooter Informations: \nEngine");
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
