using FourPillarsApp;
namespace FourPillarsTests;

public class WeaponTests
{
    [Test]//Unsure on the validity of this test.
    public void GivenNullBrand_WhenWeaponConstructed_ReturnsBrandAsEmpty()
    {
        string expectedResult = " LaserGun";
        Assert.That(new LaserGun(null).ToString(), Is.EqualTo(expectedResult));
    }
    //
    [Test]
    public void GivenLaserGun_WhenShoot_ReturnsCorrectString()
    {
        string expectedResult = "Zap!";
        Assert.That(new LaserGun("Test").Shoot(), Is.EqualTo(expectedResult));
    }
    [Test]
    public void GivenLaserGun_WhenToString_ReturnsCorrectName()
    {
        string expectedResult = "Test LaserGun";
        Assert.That(new LaserGun("Test").ToString(), Is.EqualTo(expectedResult));
    }
    [Test]
    public void GivenWaterPistol_WhenShoot_ReturnsCorrectString()
    {
        string expectedResult = "Jet of water";
        Assert.That(new WaterPistol("Test").Shoot(), Is.EqualTo(expectedResult));
    }
    [Test]
    public void GivenWaterPistol_WhenToString_ReturnsCorrectName()
    {
        string expectedResult = "Test WaterPistol";
        Assert.That(new WaterPistol("Test").ToString(), Is.EqualTo(expectedResult));
    }
    [Test]
    public void GivenBow_WhenShoot_ReturnsCorrectString()
    {
        string expectedResult = ">>--->";
        Assert.That(new Bow("Test").Shoot(), Is.EqualTo(expectedResult));
    }
    [Test]
    public void GivenBow_WhenToString_ReturnsCorrectName()
    {
        string expectedResult = "Test Bow";
        Assert.That(new Bow("Test").ToString(), Is.EqualTo(expectedResult));
    }
    [Test]
    public void GivenTrebuchet_WhenShoot_ReturnsCorrectString()
    {
        string expectedResult = "A stone weighing at least 200 pounds is thrown";
        Assert.That(new Trebuchet("Test").Shoot(), Is.EqualTo(expectedResult));
    }
    [Test]
    public void GivenTrebuchet_WhenToString_ReturnsCorrectName()
    {
        string expectedResult = "Test Trebuchet";
        Assert.That(new Trebuchet("Test").ToString(), Is.EqualTo(expectedResult));
    }
    [Test]
    public void GivenCamera_WhenShoot_ReturnsCorrectString()
    {
        string expectedResult = "Click Snap";
        Assert.That(new Camera("Test").Shoot(), Is.EqualTo(expectedResult));
    }
    [Test]
    public void GivenCamera_WhenToString_ReturnsCorrectName()
    {
        string expectedResult = "Test Camera";
        Assert.That(new Camera("Test").ToString(), Is.EqualTo(expectedResult));
    }
}
