namespace Tasks.Question2;

public interface ICheckInOutStrategy : ISimplePriorityAware
{
    bool CanProcess(IParkingPlace parkingPlace, IVehicle vehicle);

    bool CheckIn(IParkingPlace parkingPlace, IVehicle vehicle);

    void CheckOut(IParkingPlace parkingPlace, IVehicle vehicle);
}