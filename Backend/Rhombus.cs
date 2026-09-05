namespace Backend;

public class Rhombus : Square
{
    private double _d1;
    private double _d2;

    public Rhombus(string name, double a, double d1, double d2) : base(name, a)
    {
        D1 = d1;
        D2 = d2;
    }

    public double D1
    {
        get => _d1;
        set
        {
            if (!ValidateD1(value))
                throw new ArgumentException("Diagonal length must be greater than 0.");
            _d1 = value;
        }
    }

    public double D2
    {
        get => _d2;
        set
        {
            if (!ValidateD2(value))
                throw new ArgumentException("Diagonal length must be greater than 0.");
            _d2 = value;
        }
    }

    public override double GetArea()
    {
        return (D1 * D2) / 2;
    }

    public override double GetPerimeter()
    {
        return 4 * A;
    }

    private bool ValidateD1(double d1) => d1 > 0;

    private bool ValidateD2(double d2) => d2 > 0;

}
