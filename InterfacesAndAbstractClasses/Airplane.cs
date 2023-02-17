using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses;

public class Airplane : IFlyable
{
    public Coordinate _currentPosition { get; set; }
    private double speed = 200;
    private double acceleration = 10;

    public void FlyTo(Coordinate newPoint)
    {
        double distance = Math.Sqrt(Math.Pow(newPoint.X - _currentPosition.X, 2) +
                                    Math.Pow(newPoint.Y - _currentPosition.Y, 2) +
                                    Math.Pow(newPoint.Z - _currentPosition.Z, 2));

        int numSegments = (int)Math.Ceiling(distance / 10);
        for (int i = 1; i <= numSegments; i++)
        {
            speed += acceleration;
        }

        _currentPosition = newPoint;
    }

    public TimeSpan GetFlyTime(Coordinate newPoint)
    {
        double distance = Math.Sqrt(Math.Pow(newPoint.X - _currentPosition.X, 2) +
                                    Math.Pow(newPoint.Y - _currentPosition.Y, 2) +
                                    Math.Pow(newPoint.Z - _currentPosition.Z, 2));
        double time = 0;
        double currentSpeed = speed;

        int numSegments = (int)Math.Ceiling(distance / 10);
        for (int i = 1; i <= numSegments; i++)
        {
            double segmentDistance = Math.Min(10, distance - (i - 1) * 10);
            double segmentTime = segmentDistance / currentSpeed;
            time += segmentTime;
            currentSpeed += acceleration;
        }

        return TimeSpan.FromHours(time);
    }
}
