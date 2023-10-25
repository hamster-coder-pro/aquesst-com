namespace Tasks.Question2;

public abstract class ParkingPlaceModelBase : IParkingPlace
{
    protected ParkingPlaceModelBase()
    {
        Location = string.Empty;
        ParkedVehicleCollection = new List<IVehicle>();
    }

    public string Location { get; set; }

    public ICollection<IVehicle> ParkedVehicleCollection { get; set; }

    public int SpaceCount { get; set; }

    public virtual bool IsBusy()
    {
        return ParkedVehicleCollection.Count == SpaceCount;
    }

    public virtual bool IsVehicleParked(IVehicle vehicle)
    {
        return ParkedVehicleCollection.Contains(vehicle);
    }
}