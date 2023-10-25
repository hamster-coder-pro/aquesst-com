namespace Tasks.Question2;

internal sealed class GarageBusCheckInOutStrategy : TypeDependentCheckInOutStrategyBase<ParkingGarageModel, BusVehicleModel>
{
    protected override bool CheckIn(ParkingGarageModel parkingPlace, BusVehicleModel vehicle)
    {
        if (parkingPlace.SpaceCount > 0)
        {
            parkingPlace.ParkedVehicleCollection.Add(vehicle);
            parkingPlace.SpaceCount -= 1;
            return true;
        }

        return false;
    }

    protected override void CheckOut(ParkingGarageModel parkingPlace, BusVehicleModel vehicle)
    {
        if (parkingPlace.ParkedVehicleCollection.Remove(vehicle))
        {
            parkingPlace.SpaceCount += 1;
        }
    }
}