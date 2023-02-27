using DotNetCollections.CarTypes;
using System.Xml;

public class Program
{
    public static void Main(string[] args)
    {
        var listOfVehicles = new List<object>
        {
            new Truck()
            {
                EngineCapacity = 2.5, EngineType = "Diesel", SerialNumber = "T123", PowerRating = 200
            },
            new PassengerCar
            {
                EngineCapacity = 1.8, EngineType = "Petrol", SerialNumber = "P456", PowerRating = 140
            },
            new Bus
            {
                EngineCapacity = 3.0, EngineType = "Diesel", SerialNumber = "B789", PowerRating = 300
            },
            new Scooter
            {
                EngineCapacity = 0.8, EngineType = "Electric", SerialNumber = "S246", PowerRating = 30
            }
        };

        XmlDocument xmlDoc = new XmlDocument();
        XmlElement root = xmlDoc.CreateElement("Vehicles");
        xmlDoc.AppendChild(root);

        foreach (object vehicle in listOfVehicles)
        {
            XmlElement vehicleElement = null;
            if (vehicle is Truck)
            {
                if (((Truck)vehicle).EngineCapacity > 1.5)
                {
                    Truck truck = (Truck)vehicle;
                    vehicleElement = xmlDoc.CreateElement("Truck");
                    vehicleElement.SetAttribute("EngineCapacity", truck.EngineCapacity.ToString());
                    vehicleElement.SetAttribute("EngineType", truck.EngineType);
                    vehicleElement.SetAttribute("SerialNumber", truck.SerialNumber);
                    vehicleElement.SetAttribute("PowerRating", truck.PowerRating.ToString());
                }
            }
            else if (vehicle is PassengerCar && ((PassengerCar)vehicle).EngineCapacity > 1.5)
            {
                if (((PassengerCar)vehicle).EngineCapacity > 1.5)
                {
                    PassengerCar passengerCar = (PassengerCar)vehicle;
                    vehicleElement = xmlDoc.CreateElement("PassengerCar");
                    vehicleElement.SetAttribute("EngineCapacity", passengerCar.EngineCapacity.ToString());
                    vehicleElement.SetAttribute("EngineType", passengerCar.EngineType);
                    vehicleElement.SetAttribute("SerialNumber", passengerCar.SerialNumber);
                    vehicleElement.SetAttribute("PowerRating", passengerCar.PowerRating.ToString());
                }
            }
            else if (vehicle is Bus && ((Bus)vehicle).EngineCapacity > 1.5)
            {
                if (((Bus)vehicle).EngineCapacity > 1.5)
                {
                    Bus bus = (Bus)vehicle;
                    vehicleElement = xmlDoc.CreateElement("Bus");
                    vehicleElement.SetAttribute("EngineCapacity", bus.EngineCapacity.ToString());
                    vehicleElement.SetAttribute("EngineType", bus.EngineType);
                    vehicleElement.SetAttribute("SerialNumber", bus.SerialNumber);
                    vehicleElement.SetAttribute("PowerRating", bus.PowerRating.ToString());
                }
            }
            else if (vehicle is Scooter && ((Scooter)vehicle).EngineCapacity > 1.5)
            {
                if (((Scooter)vehicle).EngineCapacity > 1.5)
                {
                    Scooter scooter = (Scooter)vehicle;
                    vehicleElement = xmlDoc.CreateElement("Scooter");
                    vehicleElement.SetAttribute("EngineCapacity", scooter.EngineCapacity.ToString());
                    vehicleElement.SetAttribute("EngineType", scooter.EngineType);
                    vehicleElement.SetAttribute("SerialNumber", scooter.SerialNumber);
                    vehicleElement.SetAttribute("PowerRating", scooter.PowerRating.ToString());
                }
            }
            root.AppendChild(vehicleElement);
            xmlDoc.Save("vehicles.xml");
        }
    }
}