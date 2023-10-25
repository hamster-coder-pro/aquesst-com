namespace Tasks.Question2;

public interface IRegisterParkingService
{
    void RegisterParkingPlace(IParkingPlace parkingPlace);

    void RegisterParkingPlace(IEnumerable<IParkingPlace> parkingPlaces);
}