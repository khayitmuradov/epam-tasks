using DotNetCollections.Entities;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DotNetCollections.CarTypes
{
    [XmlInclude(typeof(object))]
    public class PassengerCar
    {
        public Engine Engine = new Engine()
        {
            Power = 690,
            Volume = 6498,
            Type = "Hybrid",
            SerialNumber = "JH4DB1542MS007683"
        };
        public Chassis Chassis = new Chassis()
        {
            WheelsNumber = 4,
            Number = "2S3TD52V3Y6103456",
            PermissibleLoad = 2200
        };
        public Transmission Transmission = new Transmission()
        {
            Type = "Automatic",
            NumberOfGears = 4,
            Manufacturer = "Lamborghini"
        };

        public PassengerCar()
        {
        }

        public PassengerCar(Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }
    }
}
