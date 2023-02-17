namespace InterfacesAndAbstractClasses;

public interface IFlyable
{
    public void FlyTo(Coordinate newPoint);
    public TimeSpan GetFlyTime(Coordinate newPoint);
}
