namespace Tasks.Question2;

internal sealed class GarageCompactCarCheckInOutStrategy : TypeDependentCheckInOutStrategyBase<ParkingGarageModel, CarVehicleModel>
{
    public override bool CanProcess(IParkingPlace parkingPlace, IVehicle vehicle)
    {
        return base.CanProcess(parkingPlace, vehicle) && ((CarVehicleModel)vehicle).Weight <= 1500;
    }

    protected override bool CheckIn(ParkingGarageModel parkingPlace, CarVehicleModel vehicle)
    {
        if (parkingPlace.CompactSpaceCount > 0)
        {
            parkingPlace.CompactSpaceParkedVehicleCollection.Add(vehicle);
            parkingPlace.CompactSpaceCount -= 1;
            return true;
        }

        return false;
    }

    protected override void CheckOut(ParkingGarageModel parkingPlace, CarVehicleModel vehicle)
    {
        if (parkingPlace.CompactSpaceParkedVehicleCollection.Remove(vehicle))
        {
            parkingPlace.CompactSpaceCount += 1;
        }
    }
}