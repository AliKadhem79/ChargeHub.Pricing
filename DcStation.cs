public class DcStation : ChargingStation
{
    public DcStation (string id) : base(id, 150)
    {
    }
    public override decimal CalculatePrice(decimal kwh)

    {

        return kwh * 5.00m + 10m;  
    }
}