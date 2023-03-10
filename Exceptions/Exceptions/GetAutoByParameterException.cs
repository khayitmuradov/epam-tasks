#nullable disable
namespace Exceptions.Exceptions;

public class GetAutoByParameterException : Exception
{
    public string Parameter { get; set; }
    public string Value { get; set; }

    public GetAutoByParameterException(string parameter, string value)
        : base($"Could not find vehicle with {parameter} = {value}.")
    {
        Parameter = parameter;
        Value = value;
    }

    public GetAutoByParameterException(string message) : base(message)
    {
    }

    public static Vehicle GetAutoByParameter(List<Vehicle> vehicles, string parameter, string value)
    {
        switch (parameter)
        {
            case "EngineCapacity":
                return vehicles.Find(v => v.EngineCapacity.ToString() == value);
            case "EngineType":
                return vehicles.Find(v => v.EngineType == value);
            case "SerialNumber":
                return vehicles.Find(v => v.SerialNumber == value);
            case "PowerRating":
                return vehicles.Find(v => v.PowerRating.ToString() == value);
            case "CarModel":
                return vehicles.Find(v => v.CarModel == value);
            default:
                return null;
        }
    }
}
