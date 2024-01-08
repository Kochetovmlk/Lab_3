using System;

struct Vector
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public Vector(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }

    public static Vector operator -(Vector v1, Vector v2)
    {
        return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
    }

    public static Vector operator *(Vector v, double scalar)
    {
        return new Vector(v.X * scalar, v.Y * scalar, v.Z * scalar);
    }

    public static Vector operator *(double scalar, Vector v)
    {
        return v * scalar;
    }

    public static double operator *(Vector v1, Vector v2)
    {
        return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
    }

    public static bool operator ==(Vector v1, Vector v2)
    {
        return v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z;
    }

    public static bool operator !=(Vector v1, Vector v2)
    {
        return !(v1 == v2);
    }

    public static bool operator >(Vector v1, Vector v2)
    {
        return v1.Length() > v2.Length();
    }

    public static bool operator <(Vector v1, Vector v2)
    {
        return v1.Length() < v2.Length();
    }

    public double Length()
    {
        return Math.Sqrt(X * X + Y * Y + Z * Z);
    }

    public override bool Equals(object obj)
    {
        if (obj is Vector other)
        {
            return this == other;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
    }
}

class Program
{
    static void Main()
    {
        Vector v1 = new Vector(1, 2, 3);
        Vector v2 = new Vector(4, 5, 6);

        Vector sum = v1 + v2;
        Vector difference = v1 - v2;
        Vector scaled = v1 * 2;
        double dotProduct = v1 * v2;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + difference);
        Console.WriteLine("Scaled: " + scaled);
        Console.WriteLine("Dot Product: " + dotProduct);

        bool isEqual = v1 == v2;
        bool isNotEqual = v1 != v2;
        bool isGreaterThan = v1 > v2;
        bool isLessThan = v1 < v2;

        Console.WriteLine("Is Equal: " + isEqual);
        Console.WriteLine("Is Not Equal: " + isNotEqual);
        Console.WriteLine("Is Greater Than: " + isGreaterThan);
        Console.WriteLine("Is Less Than: " + isLessThan);
    }

}