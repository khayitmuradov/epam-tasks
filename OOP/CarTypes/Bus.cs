using OOP.Entities;

namespace OOP.CarTypes;

public class Bus
{
    public Engine engine = new Engine();
    public Chassis chassis = new Chassis();
    public Transmission transmission = new Transmission();
}