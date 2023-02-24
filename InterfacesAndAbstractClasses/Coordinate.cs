namespace InterfacesAndAbstractClasses;
public struct Coordinate
{
    private int x;
    private int y;
    private int z;

    public Coordinate(int x, int y, int z)
    {
        if (x < 0 || y < 0 || z < 0)
        {
            throw new ArgumentException("Coordinate values cannot be negative.");
        }

        this.x = x;
        this.y = y;
        this.z = z;
    }

    public int X
    {
        get { return x; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Coordinate value cannot be negative.");
            }

            x = value;
        }
    }

    public int Y
    {
        get { return y; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Coordinate value cannot be negative.");
            }

            y = value;
        }
    }

    public int Z
    {
        get { return z; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Coordinate value cannot be negative.");
            }

            z = value;
        }
    }
}