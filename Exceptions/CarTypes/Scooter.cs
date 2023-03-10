namespace Exceptions.CarTypes;

public class Scooter : Vehicle
{
    public Scooter(double engineCapacity, string engineType, string serialNumber, int powerRating, string carModel)
        : base(engineCapacity, engineType, serialNumber, powerRating, carModel)
    {
    }
}
