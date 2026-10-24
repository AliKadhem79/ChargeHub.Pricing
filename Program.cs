var vehicle = new Vehicle(1, 75);
var ac1 = new AcStation("AC-01");
var dc1 = new DcStation("DC-01");

var reportables = new List<IReportable>
{
    vehicle,
    ac1,
    dc1
};

foreach (var item in reportables)
{
    Console.WriteLine(item.GetReport());
}

