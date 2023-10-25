namespace Tasks.Question2;

internal abstract class TypeDependentCheckInOutStrategyBase<TParking, TVehicle> : ICheckInOutStrategy
    where TParking : IParkingPlace
    where TVehicle : IVehicle
{
    public virtual bool CanProcess(IParkingPlace parkingPlace, IVehicle vehicle)
    {
        return parkingPlace is TParking && vehicle is TVehicle;
    }

    public bool CheckIn(IParkingPlace parkingPlace, IVehicle vehicle)
    {
        return CheckIn((TParking)parkingPlace, (TVehicle)vehicle);
    }

    protected abstract bool CheckIn(TParking parkingPlace, TVehicle vehicle);

    public void CheckOut(IParkingPlace parkingPlace, IVehicle vehicle)
    {
        CheckOut((TParking)parkingPlace, (TVehicle)vehicle);
    }

    protected abstract void CheckOut(TParking parkingPlace, TVehicle vehicle);
}