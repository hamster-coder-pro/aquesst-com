namespace Tasks.Question2;

public interface IVehicle
{
    string Make { get; set; }

    string Model { get; set; }

    int Wheels { get; set; }

    int Length { get; set; }

    int Weight { get; set; }

    int Passengers { get; set; }
}