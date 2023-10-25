namespace Tasks.Question2;

public interface IParkingPlace
{
    string Location { get; set; }

    ICollection<IVehicle> ParkedVehicleCollection { get; set; }

    int SpaceCount { get; set; }

    bool IsBusy();

    bool IsVehicleParked(IVehicle vehicle);
}