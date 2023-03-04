using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions;

public class Vehicle
{
    public double EngineCapacity { get; set; }
    public string? EngineType { get; set; }
    public string? SerialNumber { get; set; }
    public int PowerRating { get; set; }

    public Vehicle(double engineCapacity, string? engineType, string? serialNumber, int powerRating)
    {
        EngineCapacity = engineCapacity;
        EngineType = engineType;
        SerialNumber = serialNumber;
        PowerRating = powerRating;
    }
}
