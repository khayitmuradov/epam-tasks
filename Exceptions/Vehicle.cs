using Exceptions.Exceptions;

namespace Exceptions;

public class Vehicle
{
    public double EngineCapacity { get; set; }
    public string? EngineType { get; set; }
    public string? SerialNumber { get; set; }
    public int PowerRating { get; set; }
    public string? CarModel { get; set; }

    public Vehicle(double engineCapacity, string? engineType, string? serialNumber, int powerRating, string? carModel)
    {
        if (string.IsNullOrEmpty(carModel))
        {
            throw new InitializationException("Car model cannot be null or empty");
        }

        EngineCapacity = engineCapacity;
        EngineType = engineType;
        SerialNumber = serialNumber;
        PowerRating = powerRating;
        CarModel = carModel;
    }
}
