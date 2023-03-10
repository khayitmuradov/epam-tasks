using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesignPrinciples;

public class Car
{
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int Quantity { get; set; }
    public double CostPerUnit { get; set; }

    public Car(string brand, string model, int quantity, double costPerUnit)
    {
        Brand = brand;
        Model = model;
        Quantity = quantity;
        CostPerUnit = costPerUnit;
    }
}