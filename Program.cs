var ac1 = new AcStation("Ac-01");
var ac2 = new AcStation("Ac-02");
var dc1 = new DcStation("Dc-01");

var sessions = new List<(ChargingStation Station, decimal kwh)>
{
    (ac1, 20m),
    (dc1, 20m),
    (ac2, 12m),
    (dc1, 40m)
};

decimal total = 0m;
foreach (var s in sessions)
{
    total += s.Station.CalculatePrice(s.kwh);
}
Console.WriteLine($"dagens intäkter: {total} kr");

