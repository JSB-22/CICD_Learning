namespace FourPillarsApp;

public struct Point3D
{
    int x, y, z;

    public Point3D(int x, int y, int z = 0)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public static Point3D operator -(Point3D x, Point3D y)
    {
        return new Point3D(x.x - y.x, x.y - y.y, x.z - y.z);
    }

    public static Point3D operator +(Point3D x, Point3D y)
    {
        return new Point3D(x.x + y.x, x.y + y.y, x.z + y.z);
    }

    public double DistanceFromOrigin(int x, int y, int z)
    {
        return Math.Sqrt(x * x + y * y + z * z);
    }

    public double DistanceToPoint(Point3D point1)
    {
        return Math.Sqrt(Math.Pow((x - point1.x), 2) + Math.Pow((y - point1.y), 2) + Math.Pow((z - point1.z), 2));
    }

    public void PrintPoint()
    {
        Console.WriteLine($"({x},{y},{z})");
    }
}
