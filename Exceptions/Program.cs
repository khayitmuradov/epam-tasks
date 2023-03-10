using Exceptions;
using Exceptions.CarTypes;
using Exceptions.Exceptions;

List<Vehicle> vehicles = new List<Vehicle>();

try
{
    var bus = new Bus(3000, "Diesel", "B001", 200, "S");
    var passengerCar = new PassengerCar(1500, "Diesel", "Supa-1331", 200, "DragonLore");
}
catch (InitializationException ex)
{
    Console.WriteLine($"Initialization failed {ex.Message}");
}

try
{
    var bus = new Bus(3000, "Diesel", "B001", 200, "Isuzu");
    var passengerCar = new PassengerCar(1500, "Diesel", "Supa-1331", 200, "DragonLore");
    vehicles.Add(bus);
    vehicles.Add(passengerCar);
}
catch (AddException ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    var carId = "XYZ123";
    var newCar = new PassengerCar(2000, "Gasoline", "Supa-1332", 220, "NewCar");
    var carToUpdate = vehicles.FirstOrDefault(car => car.SerialNumber == carId);

    if (carToUpdate == null)
    {
        throw new GetAutoByParameterException($"Unable to find car with ID {carId}");
    }

    // perform update
    carToUpdate = newCar;
}
catch (GetAutoByParameterException ex)
{
    Console.WriteLine($"Error updating car: {ex.Message}");
}