namespace OOP.Entities;

public class Engine
{
    private int _power;
    private int _volume;
    private string? _type;
    private string? _serialNumber;

    public int Power
    {
        get { return _power; }
        set
        {
            if (value < 0) 
            { 
                throw new Exception("Power should be a positive integer.");
            }
        }
    }

    public int Volume
    {
        get { return _volume; }
        set
        {
            if (value < 0)
            {
                throw new Exception("Volune should be a positive integer.");
            }
        }
    }
    public string? Type
    {
        get { return _type; }
        set
        {
            if (value is null)
            {
                throw new Exception("Type should be a non-empty string.");
            }
        }
    }
    public string? SerialNumber
    {
        get { return _serialNumber; }
        set
        {
            if (value is null)
            {
                throw new Exception("Serial Number should be a non-empty string.");
            }
        }
    }
}
