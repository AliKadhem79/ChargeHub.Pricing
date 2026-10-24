public abstract class ChargingStation : IReportable
{
    public string Id { get; }
    public double MaxKw { get; }
    
    protected ChargingStation(string id, double maxkw)
    {
        Id = id;
        MaxKw = maxkw;
    }
    public string GetReport()
    {
        return $"Station {Id}: {MaxKw} kW";
    }

    public abstract decimal CalculatePrice(decimal kwh);

}