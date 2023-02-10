using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses;

public class Drone : IFlyable
{
    public Coordinate CurrentPosition { get; set; }

    public Drone(Coordinate currentPosition)
    {
        CurrentPosition = currentPosition;
    }

    public void FlyTo(Coordinate newPoint)
    {
        int distance = (int)Math.Sqrt(Math.Pow(CurrentPosition.X - newPoint.X, 2) +
                                      Math.Pow(CurrentPosition.Y - newPoint.Y, 2) +
                                      Math.Pow(CurrentPosition.Z - newPoint.Z, 2));

        if (distance > 1000)
        {
            throw new Exception("Drone can't fly more than 1000 km");
        }

        CurrentPosition = newPoint;
    }

    public int GetFlyTime(Coordinate newPoint)
    {
        int distance = (int)Math.Sqrt(Math.Pow(CurrentPosition.X - newPoint.X, 2) +
                                      Math.Pow(CurrentPosition.Y - newPoint.Y, 2) +
                                      Math.Pow(CurrentPosition.Z - newPoint.Z, 2));

        int time = (int)Math.Round((double)distance / 20);

        return time + (time / 10);
    }
}
