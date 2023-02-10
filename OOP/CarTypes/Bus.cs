using OOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CarTypes;

public class Bus
{
    public Engine Engine = new Engine()
    {
        Power = 450,
        Volume = 8560,
        Type = "Manual",
        SerialNumber = "3VWDX7AJ5BM006256"
    };
    public Chassis Chassis = new Chassis()
    {
        WheelsNumber = 6,
        Number = "1B3HB48B67D562726",
        PermissibleLoad = 8950
    };
    public Transmission Transmission = new Transmission()
    {
        Type = "Automatic",
        NumberOfGears = 8,
        Manufacturer = "BTS Bus"
    };

    public Bus()
    {
    }

    public Bus(Engine engine, Chassis chassis, Transmission transmission)
    {
        Engine = engine;
        Chassis = chassis;
        Transmission = transmission;
    }

    public void Info()
    {
        Console.WriteLine("Passenger Car: \nEngine");
        Console.WriteLine("Power: " + Engine.Power);
        Console.WriteLine("Volume: " + Engine.Volume);
        Console.WriteLine("Type: " + Engine.Type);
        Console.WriteLine("Serial Number: " + Engine.SerialNumber);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Chassis");
        Console.WriteLine("Wheels Number:" + Chassis.WheelsNumber);
        Console.WriteLine("Number: " + Chassis.Number);
        Console.WriteLine("Load: " + Chassis.PermissibleLoad);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Transmission");
        Console.WriteLine("Type: " + Transmission.Type);
        Console.WriteLine("Number Of Gears: " + Transmission.NumberOfGears);
        Console.WriteLine("Manufacturer: " + Transmission.Manufacturer);
        Console.ForegroundColor = ConsoleColor.White;
    }
}