using OOP.CarTypes;
using OOP.Entities;

namespace OOP;
public class Program
{
    public static void Main()
    {
        var passengerCar = new PassengerCar
        {
            engine = new Engine
            {
                Power = 690,
                Volume = 6498,
                Type = "Hybrid",
                SerialNumber = "JH4DB1542MS007683"
            },
            chassis = new Chassis
            {
                WheelsNumber = 4,
                Number = "2S3TD52V3Y6103456",
                PermissibleLoad = 2200
            },
            transmission = new Transmission
            {
                Type = "Automatic",
                NumberOfGears = 4,
                Manufacturer = "Lamborghini"
            }
        };

        // Print the passenger car information
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("<<<<<< Passenger Car Informations >>>>>>\nEngine");
        Console.WriteLine($"Power: {passengerCar.engine.Power}");
        Console.WriteLine($"Volume: {passengerCar.engine.Volume}");
        Console.WriteLine($"Type: {passengerCar.engine.Type}");
        Console.WriteLine($"Serial Number: {passengerCar.engine.SerialNumber}");
        Console.WriteLine("\nChassis");
        Console.WriteLine($"Wheels Number: {passengerCar.chassis.WheelsNumber}");
        Console.WriteLine($"Number: {passengerCar.chassis.Number}");
        Console.WriteLine($"Load: {passengerCar.chassis.PermissibleLoad}");
        Console.WriteLine("\nTransmission");
        Console.WriteLine($"Type: {passengerCar.transmission.Type}");
        Console.WriteLine($"Number Of Gears: {passengerCar.transmission.NumberOfGears}");
        Console.WriteLine($"Manufacturer: {passengerCar.transmission.Manufacturer}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n");


        var truck = new Truck
        {
            engine = new Engine
            {
                Power = 450,
                Volume = 14553,
                Type = "V8",
                SerialNumber = "JH4KA3250LC002400"
            },
            chassis = new Chassis
            {
                WheelsNumber = 4,
                Number = "1B7GG23Y1NS526835",
                PermissibleLoad = 4500
            },
            transmission = new Transmission
            {
                Type = "Manual",
                NumberOfGears = 4,
                Manufacturer = "Ford F-150"
            }
        };

        // Print the Truck information
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("<<<<<< Truck Informations >>>>>>\nEngine");
        Console.WriteLine($"Power: {truck.engine.Power}");
        Console.WriteLine($"Volume: {truck.engine.Volume}");
        Console.WriteLine($"Type: {truck.engine.Type}");
        Console.WriteLine($"Serial Number: {truck.engine.SerialNumber}");
        Console.WriteLine("\nChassis");
        Console.WriteLine($"Wheels Number: {truck.chassis.WheelsNumber}");
        Console.WriteLine($"Number: {truck.chassis.Number}");
        Console.WriteLine($"Load: {truck.chassis.PermissibleLoad}");
        Console.WriteLine("\nTransmission");
        Console.WriteLine($"Type: {truck.transmission.Type}");
        Console.WriteLine($"Number Of Gears: {truck.transmission.NumberOfGears}");
        Console.WriteLine($"Manufacturer: {truck.transmission.Manufacturer}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n\n");


        var bus = new Bus
        {
            engine = new Engine
            {
                Power = 450,
                Volume = 8560,
                Type = "Manual",
                SerialNumber = "3VWDX7AJ5BM006256"
            },
            chassis = new Chassis
            {
                WheelsNumber = 6,
                Number = "1B3HB48B67D562726",
                PermissibleLoad = 8950
            },
            transmission = new Transmission
            {
                Type = "Automatic",
                NumberOfGears = 8,
                Manufacturer = "BTS Bus"
            }
        };

        // Print the Bus information
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("<<<<<< Bus Informations >>>>>>\nEngine");
        Console.WriteLine($"Power: {bus.engine.Power}");
        Console.WriteLine($"Volume: {bus.engine.Volume}");
        Console.WriteLine($"Type: {bus.engine.Type}");
        Console.WriteLine($"Serial Number: {bus.engine.SerialNumber}");
        Console.WriteLine($"Chassis");
        Console.WriteLine($"Wheels Number: {bus.chassis.WheelsNumber}");
        Console.WriteLine($"Number: {bus.chassis.Number}");
        Console.WriteLine($"Load: {bus.chassis.PermissibleLoad}");
        Console.WriteLine($"Transmission");
        Console.WriteLine($"Type: {bus.transmission.Type}");
        Console.WriteLine($"Number Of Gears: {bus.transmission.NumberOfGears}");
        Console.WriteLine($"Manufacturer: {bus.transmission.Manufacturer}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n");


        var scooter = new Scooter
        {
            engine = new Engine
            {
                Power = 240,
                Volume = 1400,
                Type = "Automatic",
                SerialNumber = "JH4CC2560PC005719"
            },
            chassis = new Chassis
            {
                WheelsNumber = 2,
                Number = "WBAWC73578E067076",
                PermissibleLoad = 350
            },
            transmission = new Transmission
            {
                Type = "Automatic",
                NumberOfGears = 1,
                Manufacturer = "Super Simple"
            }
        };

        // Print the Scooter information
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("<<<<<< Scooter Informations >>>>>> \nEngine");
        Console.WriteLine($"Power: {scooter.engine.Power}");
        Console.WriteLine($"Volume: {scooter.engine.Volume}");
        Console.WriteLine($"Type: {scooter.engine.Type}");
        Console.WriteLine($"Serial Number: {scooter.engine.SerialNumber}");
        Console.WriteLine("\nChassis");
        Console.WriteLine($"Wheels Number: {scooter.chassis.WheelsNumber}");
        Console.WriteLine($"Number: {scooter.chassis.Number}");
        Console.WriteLine($"Load: {scooter.chassis.PermissibleLoad}");
        Console.WriteLine("\nTransmission");
        Console.WriteLine($"Type: {scooter.transmission.Type}");
        Console.WriteLine($"Number Of Gears: {scooter.transmission.NumberOfGears}");
        Console.WriteLine($"Manufacturer: {scooter.transmission.Manufacturer}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n");
    }
}