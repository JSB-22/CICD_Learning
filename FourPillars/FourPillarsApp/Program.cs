namespace FourPillarsApp;

public class Program
{
    static void Main()
    {
        #region Lesson
        /*Person andrew = new Person("Andrew", "Ma");
        // OR var andrew = new Person(...) OR Person andrew = new (...)
        Console.WriteLine(andrew.Age);
        andrew.Age = 22;
        
        Console.WriteLine(andrew.GetFullName());
        var talal = new Person("Talal", "Hassan", 22);
        Console.WriteLine(talal.GetFullName("Sir"));

        //object intialiser:
        var patrick = new Person("Patrick", "Ardagh") { Age = 24, Height = 300 };
        var matthew = new Person("Matthew", "Handley");
        matthew.Age = 24; matthew.Height = 150;

        Park park = new Park();

        var danielle = new Hunter("Danielle", "Massey", "Kodak");
        Console.WriteLine(danielle.Shoot());
        Console.WriteLine(danielle.ToString());

        var idris = new Hunter("Idris", "Ahmed", "Cannon");

        Console.WriteLine($"idris Equals danielle? {idris.Equals(danielle)}");
        Console.WriteLine($"idris HashCode: {idris.GetHashCode()}");
        Console.WriteLine($"idris Type: {idris.GetType()}");
        Console.WriteLine($"idris ToString: {idris}");*/
        #endregion

        #region Point3D

        /*        Point3D point = new Point3D(1, 2);
                Point3D point2 = new Point3D(0, 1);
                Console.WriteLine("Point1:");
                point.PrintPoint();
                Console.WriteLine("Point2:");
                point2.PrintPoint();
                Console.WriteLine("_____");
                Console.WriteLine("Distance between points: " + point.DistanceToPoint(point2));
                Point3D testPoint = point2 - point;
                Console.WriteLine("_____");
                testPoint.PrintPoint();*/

        #endregion

        #region Airplane:
        /*        Airplane a = new Airplane(200, 100, "JetsRUs")
                { NumPassengers = 150 };
                a.Ascend(500);
                Console.WriteLine(a.Move(3));
                Console.WriteLine(a);
                a.Descend(200);
                Console.WriteLine(a.Move());
                a.Move();
                Console.WriteLine(a);*/

        #endregion

        #region PolyMorphism
        /*var myDog = new Dog();
        var myCat = new Cat();
        var myBird = new Bird();
        Console.WriteLine(myDog.Speak());
        Console.WriteLine(myCat.Speak());
        Console.WriteLine(myBird.Speak());

        Console.WriteLine("\nPolymorphism demo:\n");
        List<Animal> animals = new List<Animal>() { myDog, myCat, myBird };
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Speak()); 
        }
        Console.WriteLine("\n");
        Animal? myAnimal;
        //string input = Console.ReadLine();
        string input = "dog";
        switch (input.ToLower())
        {
            case "dog":
                myAnimal = new Dog();
                break;
            case "cat":
                myAnimal = new Cat();
                break;
            case "bird":
                myAnimal = new Bird();
                break;
            default:
                Console.WriteLine("Not an animal!");
                myAnimal = null;
                break;
        }
        if (myAnimal is not null) Console.WriteLine(myAnimal.Speak());

        Console.WriteLine();
        List<object> gameObjects = new List<object>() { new Airplane(15),new Dog(),new Cat(),new Park(),new Person("Jacob","Banyard"),new Hunter("Majid","Laklouk","Nikon"),
        new Vehicle()};
        foreach (var obj in gameObjects)
        {
            SpartaWrite(obj);
            if(obj is Animal) SpartaWrite(((Animal)obj).Speak());
        }

     List<IMoveable> moveables = new() { new Person("Jacob", "Banyard"), new Hunter("Majid", "Laklouk", "Nikon"), new Vehicle(), new Airplane(20) };
     foreach (var movers in moveables)
     {
         SpartaWrite(movers.Move(2));
     }*/

        #endregion

        #region Poly Lab ++
        /*        //var weapons = new List<Weapon>() { new LaserGun("FuTuRe"), new WaterPistol("Amazons Own"), new Trebuchet("Wooden") , new Bow("Long")};
                var weapons = new List<IShootable>() { new LaserGun("FuTuRe"), new WaterPistol("Amazons Own"), new Trebuchet("Wooden"), new Bow("Long"), new Camera("Fujitsu") };
                foreach (var weapon in weapons)
                {
                    Console.WriteLine(weapon.Shoot());
                    Console.WriteLine(weapon.ToString());
                }*/
        var hunters = new List<IShootable>() { new Hunter("Han", "Solo", new LaserGun("Future")), new Hunter("Kid", "Nextdoor", new WaterPistol("Future")), new Hunter("Tre", "buche", new Trebuchet("Wooden")),
         new Hunter("Robin", "Hood", new Bow("Long")), new Hunter("Will", "D-Life", new Camera("Fujitsu"))};
        foreach (var hunter in hunters)
        {
            Console.WriteLine(hunter.Shoot());
        }
        Console.WriteLine();
        Hunter temp = new Hunter("1", "2", new Bow("Compound"));
        var test = temp.Shooter;
        Console.WriteLine(temp);
        #endregion
    }

    public static void SpartaWrite(object obj)
    {
        Console.WriteLine($"Sparta says: {obj}");
    }
}