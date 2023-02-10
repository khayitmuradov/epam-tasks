using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses;

public class Airplane : IFlyable
{
    public Coordinate CurrentPosition { get; set; }

    public Airplane(Coordinate currentPosition)
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

        int speed = 200;
        int time = 0;

        while (distance > 0)
        {
            int currentSpeed = Math.Min(speed, distance);
            time += (int)Math.Round((double)distance / currentSpeed);
            speed += 10;
            distance -= 10;
        }

        return time;
    }
}
