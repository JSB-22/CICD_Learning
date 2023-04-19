using FourPillarsApp;
namespace FourPillarsTests;

public class HunterTests
{
    private Hunter _sut;
    [SetUp]
    public void SetUp()
    {
        _sut = new Hunter("Test", "Case", new LaserGun("LG"));
    }

    [Test]
    public void GivenValidInput_WhenConstructed_ReturnsCorrectShoot()
    {
        string expectedResult = "Hunter Test Case shoots with a LG LaserGun: *Zap!*";
        Assert.That(_sut.Shoot(), Is.EqualTo(expectedResult));
    }
    [Test]
    public void GivenNewShooter_WhenShooter_ReturnsCorrectNewShooter()
    {
        _sut.Shooter = new Bow("LG");
        Assert.That(_sut.Shooter, Is.TypeOf<Bow>());
    }
    [Test]
    public void GivenHunter_WhenToString_ReturnsCorrectString()
    {
        string expectedResult = "FourPillarsApp.Hunter FistName: Test LastName: Case Age: 18 Height: 0 holding a LG LaserGun";
        Assert.That(_sut.ToString(), Is.EqualTo(expectedResult));
    }


}
