namespace Exceptions.CarTypes;

public class Bus : Vehicle
{
    public Bus(double engineCapacity, string engineType, string serialNumber, int powerRating, string carModel)
        : base(engineCapacity, engineType, serialNumber, powerRating, carModel)
    {
    }
}
