using DotNetCollections.CarTypes;
using DotNetCollections.Entities;
using System.Xml.Serialization;

public class Program
{
    public static void Main()
    {
        List<object> vehicles = new List<object>()
        {
            new PassengerCar
            (
                new Engine()
                {
                    Power = 650,
                    Volume = 6550,
                    Type = "Manual",
                    SerialNumber = "SAJWA0ES6DPS56028",
                    Capacity = 250
                },
                new Chassis()
                {
                    Number = "JH4DA9370PS000721",
                    PermissibleLoad = 1,
                    WheelsNumber = 1
                },
                new Transmission()
                {
                    Type = "fds",
                    Manufacturer = "fds",
                    NumberOfGears = 1,
                }
            ),
            new Bus
            (
                new Engine()
                {
                    Power = 1,
                    Volume = 1,
                    Type = "JH4KA4540JC050162",
                    SerialNumber = "JH4KA3263KC011910"
                },
                new Chassis()
                {
                    Number = "fdsf",
                    PermissibleLoad = 1,
                    WheelsNumber = 1
                },
                new Transmission()
                {
                    Type = "fds",
                    Manufacturer = "fds",
                    NumberOfGears = 1,
                }
            ),
            new Truck
            (
                new Engine()
                {
                    Power = 1,
                    Volume = 1,
                    Type = "dfsf",
                    SerialNumber = "JH4DB1542MS007683"
                },
                new Chassis()
                {
                    Number = "JH4KA7670MC006807",
                    PermissibleLoad = 1,
                    WheelsNumber = 1
                },
                new Transmission()
                {
                    Type = "fds",
                    Manufacturer = "fds",
                    NumberOfGears = 1,
                }
            ),
            new Scooter
            (
                new Engine()
                {
                    Power = 1,
                    Volume = 1,
                    Type = "dfsf",
                    SerialNumber = "3B7KF2363YG116285"
                },
                new Chassis()
                {
                    Number = "1G1ZT51FX6F111393",
                    PermissibleLoad = 1,
                    WheelsNumber = 1
                },
                new Transmission()
                {
                    Type = "fds",
                    Manufacturer = "fds",
                    NumberOfGears = 1,
                }
            ),
        };

        var xmlSerializer = new XmlSerializer(typeof(List<object>));

        using (var writer = new StreamWriter("vehicles.xml"))
        {
            xmlSerializer.Serialize(writer, vehicles);
        }
    }
}