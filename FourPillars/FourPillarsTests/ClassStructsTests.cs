using FourPillarsApp;
namespace FourPillarsTests;

public class ClassStructsTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetFullName_ReturnsCorrectFullName_ConstructOne()
    {
        Person testPerson = new Person("Test", "Case");
        string expectedResult = $"Test Case";
        Assert.That(expectedResult, Is.EqualTo(testPerson.GetFullName()));
    }

    [Test]
    public void GetFullNameVariant_ReturnsCorrectFullName_ConstructOne()
    {
        Person testPerson = new Person("Test", "Case");
        string expectedResult = $"Second Test Case";
        Assert.That(expectedResult, Is.EqualTo(testPerson.GetFullName("Second")));
    }

    [Test]
    public void GivenNullAsTitle_GetFullNameReturnsCorrectFullName_ConstructOne()
    {
        Person testPerson = new Person("Test", "Case");
        string expectedResult = $" Test Case";
        Assert.That(expectedResult, Is.EqualTo(testPerson.GetFullName(null)));
    }

    [Test]
    public void GetFullName_ReturnsCorrectFullName_ConstructTwo()
    {
        Person testPerson = new Person("Test", "Case", 1);
        string expectedResult = $"Test Case";
        Assert.That(expectedResult, Is.EqualTo(testPerson.GetFullName()));
    }

    [Test]
    public void GetFullNameVariant_ReturnsCorrectFullName_ConstructTwo()
    {
        Person testPerson = new Person("Test", "Case", 1);
        string expectedResult = $"Second Test Case";
        Assert.That(expectedResult, Is.EqualTo(testPerson.GetFullName("Second")));
    }

    [Test]
    public void GivenNoAgeInConstructor_WhenConstructed_ReturnsAge18()
    {
        Person testPerson = new Person("Test", "Case");
        int expectedAge = 18;
        Assert.That(expectedAge, Is.EqualTo(testPerson.Age));
    }

    [Test]
    public void GivenAcceptedAgeInConstructor_WhenConstructed_ReturnsCorrctPerson()
    {
        Person testPerson = new Person("Test", "Case", 1);
        int expectedAge = 1;
        Assert.That(expectedAge, Is.EqualTo(testPerson.Age));
    }

    [Test]
    public void GivenAcceptedAgeUpperInConstructor_WhenConstructed_ReturnsCorrctPerson()
    {
        Person testPerson = new Person("Test", "Case", 2000);
        int expectedAge = 2000;
        Assert.That(expectedAge, Is.EqualTo(testPerson.Age));
    }

    [Test]
    public void GivenInvalidAgeInConstructor_WhenConstructed_ReturnsPreviousValue()
    {
        Person testPerson = new Person("Test", "Case", -1);
        int expectedAge = 18;
        Assert.That(expectedAge, Is.EqualTo(testPerson.Age));
    }

    [Test]
    public void GivenInvalidAgeLowerInConstructor_WhenConstructed_ReturnsPreviousValue()
    {
        Person testPerson = new Person("Test", "Case", -1000);
        int expectedAge = 18;
        Assert.That(expectedAge, Is.EqualTo(testPerson.Age));
    }

    [Test]
    public void GivenAgeOverwrite_AfterConstruction_ReturnsCorrectNewValue()
    {
        Person testPerson = new Person("Test", "Case");
        testPerson.Age = 50;
        int expectedAge = 50;
        Assert.That(expectedAge, Is.EqualTo(testPerson.Age));
    }

    [Test]
    public void DemoTestCICD()
    {
        Assert.Fail();
    }




}