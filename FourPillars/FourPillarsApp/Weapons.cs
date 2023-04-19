namespace FourPillarsApp;

public abstract class Weapon : IShootable
{
    private string _brand;
    public abstract string Shoot();
    public Weapon(string brand)
    {
        if (brand is null)  _brand = ""; 
        else _brand = brand;

    }
    public override string ToString()
    {
        string?[] splitName = base.ToString().Split(".");
        return $"{_brand} {splitName[1]}";
    }
}

public class LaserGun : Weapon
{
    public LaserGun(string brand) : base(brand) { }
    public override string Shoot()
    {
        return "Zap!";
    }
}

public class WaterPistol : Weapon
{
    public WaterPistol(string brand) : base(brand) { }
    public override string Shoot()
    {
        return "Jet of water";
    }
}

public class Bow : Weapon
{
    public Bow(string brand) : base(brand) { }
    public override string Shoot()
    {
        return ">>--->";
    }
}


public class Trebuchet : Weapon
{
    public Trebuchet(string brand) : base(brand) { }
    public override string Shoot()
    {
        return "A stone weighing at least 200 pounds is thrown";
    }
}


