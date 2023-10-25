namespace Tasks.Question2;

internal sealed class GarageMotorcycleCheckInOutStrategy : TypeDependentCheckInOutStrategyBase<ParkingGarageModel, MotorcycleVehicleModel>
{
    protected override bool CheckIn(ParkingGarageModel parkingPlace, MotorcycleVehicleModel vehicle)
    {
        if (parkingPlace.CompactSpaceCount > 0)
        {
            parkingPlace.ParkedVehicleCollection.Add(vehicle);
            parkingPlace.CompactSpaceCount -= 1;
            return true;
        }

        if (parkingPlace.SpaceCount > 0)
        {
            parkingPlace.ParkedVehicleCollection.Add(vehicle);
            parkingPlace.SpaceCount -= 1;
            return true;
        }

        return false;
    }

    protected override void CheckOut(ParkingGarageModel parkingPlace, MotorcycleVehicleModel vehicle)
    {
        if (parkingPlace.CompactSpaceParkedVehicleCollection.Remove(vehicle))
        {
            parkingPlace.CompactSpaceCount += 1;
        }

        if (parkingPlace.ParkedVehicleCollection.Remove(vehicle))
        {
            parkingPlace.SpaceCount += 1;
        }
    }
}