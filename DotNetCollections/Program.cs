using DotNetCollections;
using System.Xml.Linq;

public class Program // 255 169
{
    public static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Truck 
            { 
                EngineCapacity = 2.5, 
                EngineType = "Diesel", 
                SerialNumber = "T123", 
                PowerRating = 200 
            },
            new PassengerCar 
            { 
                EngineCapacity = 1.8, 
                EngineType = "Petrol", 
                SerialNumber = "P456", 
                PowerRating = 140 
            },
            new Bus 
            { 
                EngineCapacity = 3.0, 
                EngineType = "Diesel", 
                SerialNumber = "B789", 
                PowerRating = 300 
            },
            new Scooter 
            { 
                EngineCapacity = 0.8, 
                EngineType = "Electric", 
                SerialNumber = "S246", 
                PowerRating = 30 
            }
        };

        XDocument xVehiclesMoreThan1point5EngineCapacity = new XDocument(
            new XElement("Vehicles",
                from vehicle in vehicles
                where vehicle.EngineCapacity > 1.5
                select
                    new XElement("Vehicle",
                        new XAttribute("Type", vehicle.GetType().Name),
                        new XElement("EngineCapacity", vehicle.EngineCapacity),
                        new XElement("EngineType", vehicle.EngineType),
                        new XElement("SerialNumber", vehicle.SerialNumber),
                        new XElement("PowerRating", vehicle.PowerRating)
                    )
            )
        );
        xVehiclesMoreThan1point5EngineCapacity.Save("vehicles.xml");

        XDocument xBusesAndTrucksDetails = new XDocument(
            new XElement("Vehicles",
                from vehicle in vehicles
                where vehicle is Bus || vehicle is Truck
                select new XElement("Vehicle",
                    new XAttribute("Type", vehicle.GetType().Name),
                    new XElement("EngineType", vehicle.EngineType),
                    new XElement("SerialNumber", vehicle.SerialNumber),
                    new XElement("PowerRating", vehicle.PowerRating)
                )
            )
        );
        xBusesAndTrucksDetails.Save("buses_and_trucks.xml");

        XDocument xVehiclesByTransmissionType = new XDocument(
                new XElement("VehiclesByTransmissionType",
                    from vehicleGroup in vehicles.GroupBy(v => v.EngineType)
                    select new XElement("TransmissionType",
                        new XAttribute("Type", vehicleGroup.Key),
                        from vehicle in vehicleGroup
                        select new XElement("Vehicle",
                            new XAttribute("Type", vehicle.GetType().Name),
                            new XElement("EngineCapacity", vehicle.EngineCapacity),
                            new XElement("SerialNumber", vehicle.SerialNumber),
                            new XElement("PowerRating", vehicle.PowerRating)
                        )
                    )
                )
            );
        xVehiclesByTransmissionType.Save("vehicles_by_transmission_type.xml");


        Console.WriteLine("All xml files are created successfully!");
    }
}

public class Truck : Vehicle
{ }

public class PassengerCar : Vehicle
{ }

public class Bus : Vehicle
{ }

public class Scooter : Vehicle
{ }