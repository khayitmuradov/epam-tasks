using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses;

public class Bird : IFlyable
{
    private readonly Random _random = new Random();
    public Coordinate CurrentPosition { get; set; }

    public Bird(Coordinate currentPosition)
    {
        CurrentPosition = currentPosition;
    }

    public void FlyTo(Coordinate newPoint)
    {
        CurrentPosition = newPoint;
    }

    public int GetFlyTime(Coordinate newPoint)
    {
        int distance = (int)Math.Sqrt(Math.Pow(CurrentPosition.X - newPoint.X, 2) +
                                      Math.Pow(CurrentPosition.Y - newPoint.Y, 2) +
                                      Math.Pow(CurrentPosition.Z - newPoint.Z, 2));

        int speed = _random.Next(0, 21);

        return (int)Math.Round((double)distance / speed);
    }
}
