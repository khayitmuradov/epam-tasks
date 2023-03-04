using Exceptions.CarTypes;

try
{
    var bus = new Bus(3.0, "Diesel", "B789", 300, "");
}
catch (TypeInitializationException ex)
{
    Console.WriteLine($"Initialization failed {ex.Message}");
}