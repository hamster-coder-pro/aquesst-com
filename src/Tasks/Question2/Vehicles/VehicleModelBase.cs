namespace Tasks.Question2;

public abstract class VehicleModelBase : IVehicle
{
    protected VehicleModelBase()
    {
        Make = string.Empty;
        Model = string.Empty;
    }

    public string Make { get; set; }
    public string Model { get; set; }
    public int Wheels { get; set; }
    public int Length { get; set; }
    public int Weight { get; set; }
    public int Passengers { get; set; }
}