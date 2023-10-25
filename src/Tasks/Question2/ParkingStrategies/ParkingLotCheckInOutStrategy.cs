namespace Tasks.Question2;

internal sealed class ParkingLotCheckInOutStrategy : TypeDependentCheckInOutStrategyBase<ParkingLotModel, IVehicle>
{
    protected override bool CheckIn(ParkingLotModel parkingPlace, IVehicle vehicle)
    {
        if (parkingPlace.ParkedVehicleCollection.Count == parkingPlace.SpaceCount)
            return false;
        parkingPlace.ParkedVehicleCollection.Add(vehicle);
        return true;
    }

    protected override void CheckOut(ParkingLotModel parkingPlace, IVehicle vehicle)
    {
        parkingPlace.ParkedVehicleCollection.Remove(vehicle);
    }
}