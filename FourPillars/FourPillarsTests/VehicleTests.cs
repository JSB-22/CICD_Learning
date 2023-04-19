using FourPillarsApp;
namespace FourPillarsTests;

public class VehicleTests
{
    [Test]
    [Category("Homework Initial Tests")]
    public void WhenADefaultVehicle_MovesTwice_ItsPositionIs20()
    {
        Vehicle v = new Vehicle();
        var result = v.Move(2);
        int expectedPosition = 20;
        string expectedOutputString = "Moving along 2 times";
        Assert.That(v.Position, Is.EqualTo(expectedPosition));
        Assert.That(result, Is.EqualTo(expectedOutputString));
    }

    [Test]
    [Category("Homework Initial Tests")]
    public void WhenAVehicleWithSpeed40_IsMovedOnce_ItsPositionIs40()
    {
        Vehicle v = new Vehicle(5, 40);
        var result = v.Move();
        int expectedPosition = 40;
        string expectedOutputString = "Moving along";
        Assert.That(v.Position, Is.EqualTo(expectedPosition));
        Assert.That(result, Is.EqualTo(expectedOutputString));
    }

    [Test]
    [Category("Vehicle Constructor Tests")]
    public void WhenAVehicleIsCreated_UsingDefaultConstructor_ReturnsCorrectVehicle()
    {
        Vehicle v = new Vehicle();
        int expectedPosition = 0;
        int expectedSpeed = 10;
        int expectedNumPassengers = 0;
        Assert.That(v.Position, Is.EqualTo(expectedPosition));
        Assert.That(v.Speed, Is.EqualTo(expectedSpeed));
        Assert.That(v.NumPassengers, Is.EqualTo(expectedNumPassengers));
    }

    [Test]
    [Category("Vehicle Constructor Tests")]
    public void WhenAVehicleIsCreated_UsingSecondConstructor_ReturnsCorrectVehicle()
    {
        Vehicle v = new Vehicle(3, 15);
        int expectedPosition = 0;
        int expectedSpeed = 15;
        int expectedNumPassengers = 0;
        Assert.That(v.Position, Is.EqualTo(expectedPosition));
        Assert.That(v.Speed, Is.EqualTo(expectedSpeed));
        Assert.That(v.NumPassengers, Is.EqualTo(expectedNumPassengers));
    }

    [Test]
    [Category("NumPassengers Tests")]
    public void WhenAValidPassengerInput_VehicleNumPassengers_ReturnsInput()
    {
        Vehicle v = new Vehicle(3, 15);
        v.NumPassengers = 3;
        int expectedNumPassengers = 3;
        Assert.That(v.NumPassengers, Is.EqualTo(expectedNumPassengers));
    }

    [Test]
    [Category("NumPassengers Tests")]
    public void WhenInvalidNegativePassengerInput_VehicleNumPassengers_ReturnsDefaultZero()
    {
        Vehicle v = new Vehicle(3, 15);
        v.NumPassengers = -1;
        int expectedNumPassengers = 0;
        Assert.That(v.NumPassengers, Is.EqualTo(expectedNumPassengers));
    }

    [Test]
    [Category("NumPassengers Tests")]
    public void WhenInvalidPassengerInputGreaterThanCapacity_VehicleNumPassengers_ReturnsDefaultZero()
    {
        Vehicle v = new Vehicle(3, 15);
        v.NumPassengers = 5;
        int expectedNumPassengers = 0;
        Assert.That(v.NumPassengers, Is.EqualTo(expectedNumPassengers));
    }

    [Test]
    [Category("Move Tests")]
    public void WhenAVehicleWithNegativeSpeedMinus10_IsMovedOnce_ItsPositionIsMinus10()
    {
        Vehicle v = new Vehicle(5, -10);
        var result = v.Move();
        int expectedPosition = -10;
        string expectedOutputString = "Moving along";
        Assert.That(v.Position, Is.EqualTo(expectedPosition));
        Assert.That(result, Is.EqualTo(expectedOutputString));
    }

    [Test]
    [Category("Move Tests")]
    public void WhenAVehicleWithNegativeSpeedMinus10_IsMovedTwice_ItsPositionIsMinus20()
    {
        Vehicle v = new Vehicle(5, -10);
        var result = v.Move(2);
        int expectedPosition = -20;
        string expectedOutputString = "Moving along 2 times";
        Assert.That(v.Position, Is.EqualTo(expectedPosition));
        Assert.That(result, Is.EqualTo(expectedOutputString));
    }

    [Test]
    [Category("Move Tests")]
    public void WhenAVehicleWith0Speed_IsMovedOnce_ItsPositionRemains()
    {
        Vehicle v = new Vehicle(5, 0);
        var result = v.Move();
        int expectedPosition = 0;
        string expectedOutputString = "Moving along";
        Assert.That(v.Position, Is.EqualTo(expectedPosition));
        Assert.That(result, Is.EqualTo(expectedOutputString));
    }

    [Test]
    [Category("Move Tests")]
    public void WhenAVehicleWith0Speed_IsMovedTwice_ItsPositionRemains()
    {
        Vehicle v = new Vehicle(5, 0);
        var result = v.Move(2);
        int expectedPosition = 0;
        string expectedOutputString = "Moving along 2 times";
        Assert.That(v.Position, Is.EqualTo(expectedPosition));
        Assert.That(result, Is.EqualTo(expectedOutputString));
    }
    [Test]
    [Category("To String Tests")]
    public void GivenVehicleCapacity_WhenToString_ReturnCorrectString()
    {
        Vehicle v = new Vehicle(5, 0);
        string expectedOutputString = "FourPillarsApp.Vehicle capacity: 5 passengers: 0 speed: 0 position: 0";
        Assert.That(v.ToString(), Is.EqualTo(expectedOutputString));
    }
    [Test]
    [Category("To String Tests")]
    public void GivenVehicleWithNoCapacity_WhenToString_ReturnCorrectString()
    {
        Vehicle v = new Vehicle();
        string expectedOutputString = "FourPillarsApp.Vehicle capacity: 0 passengers: 0 speed: 10 position: 0";
        Assert.That(v.ToString(), Is.EqualTo(expectedOutputString));
    }
}
