using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCollections;

public abstract class Vehicle
{
    public double EngineCapacity { get; set; }
    public string? EngineType { get; set; }
    public string? SerialNumber { get; set; }
    public int PowerRating { get; set; }
}
