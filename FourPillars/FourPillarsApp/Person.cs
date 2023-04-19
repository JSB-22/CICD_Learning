namespace FourPillarsApp;

public class Person : IMoveable, ISpeakable
{
    private string _firstName;
    private string _lastName;
    private int _age = 18;
    public int Age
    {
        get { return _age; }
        set { if (value > 0) _age = value; }
    }

    public int Height { get; set; }

    public Person(string fName, string lName)
    {
        _firstName = fName;
        _lastName = lName;
    }

    public Person(string fName, string lName, int age) : this(fName, lName)
    {
        Age = age;
    }

    public virtual string GetFullName()
    {
        return $"{_firstName} {_lastName}";
    }

    public virtual string GetFullName(string title)
    {
        return $"{title} {GetFullName()}";
    }

    public override string ToString()
    {
        return $"{base.ToString()} FistName: {_firstName} LastName: {_lastName} Age: {Age} Height: {Height}";
    }

    public string Move()
    {
        return "Walking along";
    }

    public string Move(int times)
    {
        return $"{Move()} {times} times";
    }

    public string Speak()
    {
        return "Hello there";
    }
}