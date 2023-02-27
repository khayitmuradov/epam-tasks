namespace InterfacesAndAbstractClasses;

public class Bird : IFlyable
{
    public Coordinate _currentPosition;
    private double speed = new Random().Next(0, 21);

    public void FlyTo(Coordinate newPoint)
    {
        _currentPosition = newPoint;
    }

    public TimeSpan GetFlyTime(Coordinate newPoint)
    {
        double distance = Math.Sqrt(Math.Pow(newPoint.X - _currentPosition.X, 2) +
                                    Math.Pow(newPoint.Y - _currentPosition.Y, 2) +
                                    Math.Pow(newPoint.Z - _currentPosition.Z, 2));

        double time = distance / speed;

        return TimeSpan.FromHours(time);
    }
}
