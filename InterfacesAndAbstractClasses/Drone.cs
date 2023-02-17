namespace InterfacesAndAbstractClasses;

public class Drone : IFlyable
{
    private Coordinate _currentPosition { get; set; }

    public Drone(Coordinate currentPosition)
    {
        _currentPosition = currentPosition;
    }

    public void FlyTo(Coordinate newPoint)
    {
        int distance = (int)Math.Sqrt(Math.Pow(_currentPosition.X - newPoint.X, 2) +
                                      Math.Pow(_currentPosition.Y - newPoint.Y, 2) +
                                      Math.Pow(_currentPosition.Z - newPoint.Z, 2));

        if (distance > 1000)
        {
            throw new Exception("Drone can't fly more than 1000 km");
        }

        _currentPosition = newPoint;
    }

    public int GetFlyTime(Coordinate newPoint)
    {
        int distance = (int)Math.Sqrt(Math.Pow(_currentPosition.X - newPoint.X, 2) +
                                      Math.Pow(_currentPosition.Y - newPoint.Y, 2) +
                                      Math.Pow(_currentPosition.Z - newPoint.Z, 2));

        int time = (int)Math.Round((double)distance / 20);

        return time + (time / 10);
    }
}
