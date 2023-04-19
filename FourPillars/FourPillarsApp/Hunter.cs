namespace FourPillarsApp;

public class Hunter : Person, IShootable
{
    public IShootable Shooter {get;set;}

    public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
    {
        Shooter = shooter;
    }
    public string Shoot()
    {
        return $"{GetFullName()} shoots with a {Shooter}: *{Shooter.Shoot()}*";
    }
    public override string ToString()
    {
        return $"{base.ToString()} holding a {Shooter}";
    }

    public override string GetFullName()
    {
        return $"Hunter {base.GetFullName()}";
    }
}
