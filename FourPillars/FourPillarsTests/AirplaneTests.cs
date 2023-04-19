using FourPillarsApp;
namespace FourPillarsTests
{
    public class AirplaneTests
    {
        [Test]
        public void AirplaneClassConstructsCorrectly_Default()
        {
            Airplane a = new Airplane(200);
            int expectedPosition = 0;
            int expectedSpeed = 10;
            int expectedNumPassengers = 0;
            Assert.That(a.Position, Is.EqualTo(expectedPosition));
            Assert.That(a.Speed, Is.EqualTo(expectedSpeed));
            Assert.That(a.NumPassengers, Is.EqualTo(expectedNumPassengers));
        }

        [Test]
        public void AirplaneClassConstructsCorrectly_ConstructorTwo()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs");
            int expectedPosition = 0;
            int expectedSpeed = 100;
            int expectedNumPassengers = 0;
            Assert.That(a.Position, Is.EqualTo(expectedPosition));
            Assert.That(a.Speed, Is.EqualTo(expectedSpeed));
            Assert.That(a.NumPassengers, Is.EqualTo(expectedNumPassengers));
        }

        [Test]
        public void GivenAirplaneADefaultConstruct_WhenToString_ReturnsCorrectString()
        {
            Airplane a = new Airplane(200);
            string expectedResult = "Thank you for flying : FourPillarsApp.Airplane capacity: 200 passengers: 0 speed: 10 position: 0 altitude: 0";
            Assert.That(a.ToString(), Is.EqualTo(expectedResult));
        }

        [Test]
        public void GivenAirplaneAConstructTwo_WhenToString_ReturnsCorrectString()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs");
            string expectedResult = "Thank you for flying JetsRUs: FourPillarsApp.Airplane capacity: 200 passengers: 0 speed: 100 position: 0 altitude: 0";
            Assert.That(a.ToString(), Is.EqualTo(expectedResult));
        }

        [Test]
        public void GivenAirplaneA_whenAscendValid_ReturnCorrectNewAltitude()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs");
            a.Ascend(100);
            int expectedResult = 100;
            Assert.That(a.Altitude, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GivenAirplaneA_whenAscendInValid_ReturnException()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs");
            a.Ascend(100);
            Assert.That(() => a.Ascend(1000000), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void GivenAirplaneA_whenAscendInValid_ReturnExceptionMessage()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs");
            a.Ascend(100);
            Assert.That(() => a.Ascend(1000000), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Space travel is not valid for this vehicle"));
        }


        [Test]
        public void GivenAirplaneA_whenDescendValid_ReturnCorrectNewAltitude()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs");
            a.Ascend(100);
            a.Descend(50);
            int expectedResult = 50;
            Assert.That(a.Altitude, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GivenAirplaneA_whenDescendInValid_ReturnException()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs");
            a.Ascend(100);
            Assert.That(() => a.Descend(1000000), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void GivenAirplaneA_whenDescendInValid_ReturnExceptionMessage()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs");
            a.Ascend(100);
            Assert.That(() => a.Descend(1000000), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Descending this height results in crash"));
        }
    }
}
