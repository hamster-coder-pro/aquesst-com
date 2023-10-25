namespace Tasks.Question2;

public interface IParkingService
{
    bool CheckIn(string location, IVehicle vehicle);

    bool CheckOut(IVehicle vehicle);
}