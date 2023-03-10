namespace Exceptions.CarTypes;

public class PassengerCar : Vehicle
{
    public PassengerCar(double engineCapacity, string engineType, string serialNumber, int powerRating, string carModel)
        : base(engineCapacity, engineType, serialNumber, powerRating, carModel)
    {
    }
}
