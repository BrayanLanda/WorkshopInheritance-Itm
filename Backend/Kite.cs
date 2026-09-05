namespace Backend;

public class Kite : Rhombus
{
    private double _b;

    public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
    {
        B = b;
    }

    public double B
    {
        get => _b;
        set
        {
            if (!ValidateB(value))
                throw new ArgumentException("Side length must be greater than 0.");
            _b = value;
        }
    }

    public override double GetArea()
    {
        return (D1 * D2) / 2;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private bool ValidateB(double b) => b > 0;
}
