namespace Tasks.Question2;

public interface IIsCompactParkingPlace
{
    ICollection<IVehicle> CompactSpaceParkedVehicleCollection { get; set; }

    int CompactSpaceCount { get; set; }
}