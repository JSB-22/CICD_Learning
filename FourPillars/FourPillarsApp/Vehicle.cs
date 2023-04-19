namespace FourPillarsApp;

public class Vehicle : IMoveable
{
    private int _capacity;
    private int _numPassengers;

    public int Position { get; private set; }
    public int Speed { get; init; } = 10;
    public int NumPassengers { get { return _numPassengers; } set { if (value <= _capacity && value > 0) _numPassengers = value; } }

    public Vehicle()
    {
    }
    public Vehicle(int capacity, int speed = 10)
    {
        _capacity = capacity;
        Speed = speed;
    }

    public virtual string Move()
    {
        Position += Speed;
        return $"Moving along";
    }
    public virtual string Move(int times)
    {
        Position += (Speed * (times));
        return $"Moving along {times} times";
    }

    public override string ToString()
    {
        return $"{base.ToString()} capacity: {_capacity} passengers: {NumPassengers} speed: {Speed} position: {Position}";
    }
}
