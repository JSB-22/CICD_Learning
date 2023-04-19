namespace FourPillarsApp;

public class Airplane : Vehicle
{
    private string _airline = "";
    public int Altitude { get; private set; }

    public Airplane(int capacity) : base(capacity) { }
    public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
    {
        _airline = airline;
    }
    public void Ascend(int distance)
    {
        if (Altitude + distance < 100000) Altitude += distance;
        else throw new ArgumentOutOfRangeException("Space travel is not valid for this vehicle");
    }
    public void Descend(int distance)
    {
        if (Altitude - distance > 0) Altitude -= distance;
        else throw new ArgumentOutOfRangeException("Descending this height results in crash");
    }
    public override string Move()
    {
        return $"{base.Move()} at an altitude of {Altitude} metres";
    }
    public override string Move(int times)
    {
        return $"{base.Move(times)} at an altitude of {Altitude} metres";
    }
    public override string ToString()
    {
        return $"Thank you for flying {_airline}: {base.ToString()} altitude: {Altitude}";
    }



}
