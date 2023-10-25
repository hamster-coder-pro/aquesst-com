namespace Tasks.Question2;

public sealed class ParkingGarageModel : ParkingPlaceModelBase, IIsCompactParkingPlace
{
    public ParkingGarageModel()
    {
        CompactSpaceParkedVehicleCollection = new List<IVehicle>();
    }

    public ICollection<IVehicle> CompactSpaceParkedVehicleCollection { get; set; }

    public int CompactSpaceCount { get; set; }

    public override bool IsBusy()
    {
        return base.IsBusy() && CompactSpaceParkedVehicleCollection.Count == CompactSpaceCount;
    }

    public override bool IsVehicleParked(IVehicle vehicle)
    {
        return base.IsVehicleParked(vehicle) || CompactSpaceParkedVehicleCollection.Contains(vehicle);
    }
}