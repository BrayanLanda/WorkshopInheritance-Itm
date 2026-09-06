namespace Backend;

public class Trapeze : Triangle
{
    private double _d;

    public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
    {
        D = d;
    }

    public double D
    {
        get => _d;
        set
        {
            if (!ValidateD(value))
                throw new ArgumentException("Side D must be greater than 0.");
            _d = value;
        }
    }

    public override double GetArea()
    {
        return ((A + C) * H) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C + D;
    }
    private bool ValidateD(double d) => d > 0;
}
