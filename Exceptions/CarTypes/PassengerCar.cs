using Exceptions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.CarTypes;

public class PassengerCar : Vehicle
{
    public string CarModel { get; set; }

	public PassengerCar(double engineCapacity, string engineType, string serialNumber, int powerRating, string carModel)
		: base(engineCapacity, engineType, serialNumber, powerRating)
	{
		if (string.IsNullOrEmpty(carModel))
		{
			throw new InitializationException("Car Model is empty.");
        }

		CarModel = carModel;
    }
}
