using DotNetCollections.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCollections.CarTypes
{
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
    }
}