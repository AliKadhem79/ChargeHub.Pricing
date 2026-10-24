public class Vehicle : IReportable
{
    private double _percent;

    public int Id { get; }
    public double BatteryKwh { get; }

    public double Percent
    {
        get => _percent;
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "Percent måste vara mellan 0 och 100."
                );

            _percent = value;
        }
    }

    public Vehicle(int id, double batteryKwh)
    {
        if (batteryKwh <= 0)
            throw new ArgumentOutOfRangeException(
                nameof(batteryKwh),
                "Batterikapaciteten måste vara större än 0."
            );

        Id = id;
        BatteryKwh = batteryKwh;
    }

    public double EnergyNeeded()
    {
        return BatteryKwh * (100 - Percent) / 100.0;
    }
    public string GetReport()
    {
        return $"BIl {Id}: {Percent} %";
    }
}