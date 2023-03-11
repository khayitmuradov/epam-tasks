namespace OOP.Entities;
#pragma warning disable
public class Chassis
{
    private int _wheels;
    private int _permissibleLoad;
    private string? _number;

    public int WheelsNumber
    {
        get { return _wheels; }
        set
        {
            if (value < 0 || value > 12)
            {
                throw new Exception("Number of wheels must be between 1 and 12.");
            }
        }
    }

    public string? Number
    {
        get { return _number; }
        set
        {
            if (value == null)
            {
                throw new Exception("Chassis number should be positive.");
            }
        }
    }

    public int PermissibleLoad
    {
        get { return _permissibleLoad; }
        set
        {
            if (value < 0)
            {
                throw new Exception("Number of weight limits should be more than 0");
            }
        }
    }
}
