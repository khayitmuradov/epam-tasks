namespace InterfacesAndAbstractClasses;

public class Drone : IFlyable
{
    public Coordinate _currentPosition { get; set; }
    private double speed = 50;
    private double hoverTime = 1;
    private double maxRange = 1000;

    public void FlyTo(Coordinate newPoint)
    {
        double distance = Math.Sqrt(Math.Pow(newPoint.X - _currentPosition.X, 2) +
                                    Math.Pow(newPoint.Y - _currentPosition.Y, 2) +
                                    Math.Pow(newPoint.Z - _currentPosition.Z, 2));

        if (distance > maxRange)
        {
            throw new ArgumentException("Cannot fly more than 1000 km");
        }

        double time = distance / speed;
        double hoverCount = time / 10;
        time += hoverCount * hoverTime / 60;

        _currentPosition = newPoint;
    }

    public TimeSpan GetFlyTime(Coordinate newPoint)
    {
        double distance = Math.Sqrt(Math.Pow(newPoint.X - _currentPosition.X, 2) +
                                    Math.Pow(newPoint.Y - _currentPosition.Y, 2) +
                                    Math.Pow(newPoint.Z - _currentPosition.Z, 2));

        if (distance > maxRange)
        {
            throw new ArgumentException("Cannot fly more than 1000 km");
        }

        double time = distance / speed;
        double hoverCount = time / 10;
        time += hoverCount * hoverTime / 60;

        return TimeSpan.FromHours(time);
    }
}
