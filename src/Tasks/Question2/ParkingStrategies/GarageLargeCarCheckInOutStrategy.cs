namespace Tasks.Question2;

internal sealed class GarageLargeCarCheckInOutStrategy : TypeDependentCheckInOutStrategyBase<ParkingGarageModel, CarVehicleModel>
{
    public override bool CanProcess(IParkingPlace parkingPlace, IVehicle vehicle)
    {
        return base.CanProcess(parkingPlace, vehicle) && ((CarVehicleModel)vehicle).Weight > 1500;
    }

    protected override bool CheckIn(ParkingGarageModel parkingPlace, CarVehicleModel vehicle)
    {
        if (parkingPlace.SpaceCount > 0)
        {
            parkingPlace.ParkedVehicleCollection.Add(vehicle);
            parkingPlace.SpaceCount -= 1;
            return true;
        }

        return false;
    }

    protected override void CheckOut(ParkingGarageModel parkingPlace, CarVehicleModel vehicle)
    {
        if (parkingPlace.ParkedVehicleCollection.Remove(vehicle))
        {
            parkingPlace.SpaceCount += 1;
        }
    }
}