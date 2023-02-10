using DotNetCollections.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCollections.CarTypes
{
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

        public Truck()
        {
        }

        public Truck(Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }
    }
}
