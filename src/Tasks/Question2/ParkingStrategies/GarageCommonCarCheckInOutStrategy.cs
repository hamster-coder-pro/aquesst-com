namespace Tasks.Question2;

/// <summary>
/// This is example of more common strategy of processing <see cref="CarVehicleModel"/> for <see cref="ParkingGarageModel"/>
/// <remarks>
/// In <see cref="GarageCompactCarCheckInOutStrategy"/> and <see cref="GarageLargeCarCheckInOutStrategy"/> I
/// clearly divided the two types of cars by weight. However this is not necessary and a common processing approach
/// of Cars can be applied. But in this case <see cref="GarageCommonCarCheckInOutStrategy.PriorityIndex"/> of this strategy should be larger than in
/// </remarks>
/// </summary>
internal sealed class GarageCommonCarCheckInOutStrategy : TypeDependentCheckInOutStrategyBase<ParkingGarageModel, CarVehicleModel>
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