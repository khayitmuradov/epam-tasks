using InterfacesAndAbstractClasses;
#nullable disable
public class Program
{
    public static void Main()
    {
        Bird bird = new Bird();
        Airplane airplane = new Airplane();
        Drone drone = new Drone();


        bird._currentPosition = new Coordinate(0, 0, 0);
        airplane._currentPosition = new Coordinate(0, 0, 0);
        drone._currentPosition = new Coordinate(0, 0, 0);

        int birdX = int.Parse(Console.ReadLine());
        int birdY = int.Parse(Console.ReadLine());
        int birdZ = int.Parse(Console.ReadLine());

        if (birdX < 0 || birdY < 0 || birdZ < 0)
        {
            throw new Exception("Coordinate should not be less than 0");
        }
        else
        {
            bird.FlyTo(new Coordinate(10, 10, 10));
            Console.WriteLine($"Bird estimated flight time: {bird.GetFlyTime(new Coordinate(15, 13, 10))}");
        }

        int airplaneX = int.Parse(Console.ReadLine());
        int airplaneY = int.Parse(Console.ReadLine());
        int airplaneZ = int.Parse(Console.ReadLine());

        if (airplaneX < 0 && airplaneY < 0 && airplaneZ < 0)
        {
            throw new Exception("Coordinate should not be less than 0");
        }
        else
        {
            airplane.FlyTo(new Coordinate(100, 100, 100));
            Console.WriteLine($"Airplane estimated flight time: {airplane.GetFlyTime(new Coordinate(110, 115, 200))}");
        }

        int droneX = int.Parse(Console.ReadLine());
        int droneY = int.Parse(Console.ReadLine());
        int droneZ = int.Parse(Console.ReadLine());

        if (droneX < 0 && droneY < 0 && droneZ < 0)
        {
            throw new Exception("Coordinate should not be less than 0");
        }
        else
        {
            drone.FlyTo(new Coordinate(50, 50, 50));
            Console.WriteLine($"Drone estimated flight time: {drone.GetFlyTime(new Coordinate(50, 50, 50))}");
        }
    }
}