// open readme.txt for more info

using OOPDesignPrinciples;

CarInventoryManager carManager = CarInventoryManager.GetInstance();

Console.WriteLine("Enter car information (brand, model, quantity, cost per unit), or type 'done' to finish:");
string? input = Console.ReadLine();
while (input != "done")
{
    string[] carData = input.Split(',');
    string brand = carData[0];
    string model = carData[1];
    int quantity = int.Parse(carData[2]);
    double costPerUnit = double.Parse(carData[3]);
    Car car = new Car(brand, model, quantity, costPerUnit);
    carManager.AddCar(car);
    input = Console.ReadLine();
}

string? command = "";
while (command != "exit")
{
    Console.WriteLine("Enter a command (count types, count all, average price, average price type [brand]), or type 'exit' to quit:");
    command = Console.ReadLine();

    switch (command)
    {
        case "count types":
            Console.WriteLine("Number of car brands: " + carManager.CountBrands());
            break;
        case "count all":
            Console.WriteLine("Total cars: " + carManager.CountCars());
            break;
        case "average price":
            Console.WriteLine("Average price: " + carManager.AveragePrice());
            break;
        default:
            if (command.StartsWith("average price type"))
            {
                string[] commandData = command.Split(' ');
                string brand = commandData[3];
                Console.WriteLine("Average price " + brand + ": " + carManager.AveragePriceByBrand(brand));
            }
            break;
    }
}