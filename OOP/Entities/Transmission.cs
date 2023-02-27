namespace OOP.Entities;

public class Transmission
{
    private string? _type;
    private int _numberOfGears;
    private string? _manufacturer;

    public string? Type
    {
        get { return _type; }
        set
        {
            if (value == null)
            {
                throw new Exception("Type should be a non-empty string.");
            }
        }
    }

    public int NumberOfGears
    {
        get { return _numberOfGears; }
        set
        {
            if (value < 0)
            {
                throw new Exception("Number Of gears should be a positive integer.");
            }
        }
    }

    public string? Manufacturer
    {
        get { return _manufacturer; }
        set
        {
            if (value == null)
            {
                throw new Exception("Manufacturer name should be a non-empty string.");
            }
        }
    }
}
