namespace OOPDesignPrinciples;

public class CarInventoryManager
{
    private static CarInventoryManager? instance;

    private List<Car> cars = new List<Car>();

    private CarInventoryManager() { }

    public static CarInventoryManager GetInstance()
    {
        if (instance == null)
        {
            instance = new CarInventoryManager();
        }
        return instance;
    }

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public int CountBrands()
    {
        return cars.Select(c => c.Brand).Distinct().Count();
    }

    public int CountCars()
    {
        return cars.Sum(c => c.Quantity);
    }

    public double AveragePrice()
    {
        return cars.Average(c => c.CostPerUnit);
    }

    public double AveragePriceByBrand(string brand)
    {
        return cars.Where(c => c.Brand == brand).Average(c => c.CostPerUnit);
    }
}
