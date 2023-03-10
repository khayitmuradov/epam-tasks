namespace Exceptions.Exceptions;

public class AddException : Exception
{
    public AddException() { }
    public AddException(string message) : base(message) { }
    public AddException(string message, Exception inner) : base(message, inner) { }

    private readonly List<Vehicle> _vehicles = new List<Vehicle>();

    public void AddVehicle(Vehicle vehicle)
    {
        if (vehicle == null)
        {
            throw new ArgumentNullException(nameof(vehicle));
        }

        if (_vehicles.Exists(v => v.CarModel == vehicle.CarModel))
        {
            throw new AddException($"A vehicle with the car model {vehicle.CarModel} already exists");
        }

        _vehicles.Add(vehicle);
    }
}
