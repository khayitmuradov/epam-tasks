namespace InterfacesAndAbstractClasses;

public interface IFlyable
{
    public void FlyTo(Coordinate newPoint);
    public int GetFlyTime(Coordinate newPoint);
}
