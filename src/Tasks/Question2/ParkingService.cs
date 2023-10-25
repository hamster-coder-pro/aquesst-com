namespace Tasks.Question2;

internal sealed class ParkingService: IRegisterParkingService, IParkingService
{
    private ICollection<IParkingPlace> ParkingCollection { get; }

    private ICollection<ICheckInOutStrategy> CheckInOutStrategyCollection { get; }

    // strategies will be auto injected by DI
    public ParkingService(IEnumerable<ICheckInOutStrategy> checkInOutStrategies)
    {
        ParkingCollection = new HashSet<IParkingPlace>();
        CheckInOutStrategyCollection = checkInOutStrategies.OrderBy(x => x.PriorityIndex).ToList();
    }

    public void RegisterParkingPlace(IParkingPlace parkingPlace)
    {
        ParkingCollection.Add(parkingPlace);
    }

    public void RegisterParkingPlace(IEnumerable<IParkingPlace> parkingPlaces)
    {
        foreach (var parkingPlace in parkingPlaces)
        {
            RegisterParkingPlace(parkingPlace);
        }
    }

    public bool CheckIn(string location, IVehicle vehicle)
    {
        var freeParkingCollection = ParkingCollection.Where(x => x.Location == location && x.IsBusy() == false);
        foreach (var parkingPlace in freeParkingCollection)
        {
            foreach (var checkInOutStrategy in CheckInOutStrategyCollection)
            {
                if (checkInOutStrategy.CanProcess(parkingPlace, vehicle) &&
                    checkInOutStrategy.CheckIn(parkingPlace, vehicle))
                {
                    return true;
                }
            }
        }

        return false;
    }

    public bool CheckOut(IVehicle vehicle)
    {
        var parking = ParkingCollection.FirstOrDefault(x => x.IsVehicleParked(vehicle));
        if (parking != null)
        {
            foreach (var checkInOutStrategy in CheckInOutStrategyCollection)
            {
                if (checkInOutStrategy.CanProcess(parking, vehicle))
                {
                    checkInOutStrategy.CheckOut(parking, vehicle);
                    return true;
                }
            }
        }

        return false;
    }
}