namespace FourPillarsApp;

public abstract class Animal
{
    private string _name;
    public string Kingdom { get; set; }
    public int Legs { get; set; }
    public DateTime Age { get; set; }
    public bool HasTail { get; set; }
    public abstract string Speak();
    public virtual int Move()
    {
        return 0;
    }
/*
    public Animal()
    {
        _name = "bob";
    }*/

}

public class Dog : Animal
{
    public int Speed { get; set; } = 10;
    public override int Move()
    {
        return Speed;
    }

    public sealed override string Speak()
    {
        return "Woof";
    }
}

public class Cat : Animal
{
    public override string Speak()
    {
        return "Meow";
    }
}

public class Bird : Animal
{
    public override string Speak()
    {
        return "Cheep";
    }
}


