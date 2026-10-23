public class AcStation : ChargingStation
{
    public AcStation(string id) : base(id, 11)
    {
    }

    public override decimal CalculatePrice(decimal kwh)
    {
        return kwh * 3.50m;
    }
}