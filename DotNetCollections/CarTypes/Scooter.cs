using DotNetCollections.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCollections.CarTypes
{
    public class Scooter
    {
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

        public Scooter()
        {
        }

        public Scooter(Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }
    }

}