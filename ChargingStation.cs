public abstract class ChargingStation
{
    public string Id { get; }
    public double MaxKw { get; }
    
    protected ChargingStation(string id, double maxkw)
    {
        Id = id;
        MaxKw = maxkw;
    }

    public abstract decimal CalculatePrice(decimal kwh);

}