namespace Backend;

public class Square : GeometricFigure
{
    private double _a;

    public Square(string name, double a) : base(name)
    {
        A = a;
    }
    public double A 
    { 
        get => _a; 
        set
        {
            if (!ValidateA(value))
            {
                throw new ArgumentException("Side length must be greater than 0.");
            }
            _a = value;
        }
    }

    public override double GetArea()
    {
        return A * A;
    }

    public override double GetPerimeter()
    {
        return 4 * A;
    }

    private bool ValidateA(double a) => a > 0;
}
