namespace Exceptions.CarTypes;

public class Truck : Vehicle
{
    public Truck(double engineCapacity, string engineType, string serialNumber, int powerRating, string carModel)
        : base(engineCapacity, engineType, serialNumber, powerRating, carModel)
    {
    }
}
