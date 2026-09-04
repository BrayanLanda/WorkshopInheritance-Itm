namespace Backend;

public class Circle : GeometricFigure
{
    private double _r;
    public Circle(string name, double r) : base(name)
    {
        R = r;
    }

    public double R
    {
        get => _r;
        set
        {
            if (!ValidateR(value))
            {
                throw new ArgumentException("Radius must be greater than 0.");
            }
            _r = value;
        }
    }

    public override double GetArea()
    {
        return Math.PI * _r * _r;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * _r;
    }

    private bool ValidateR(double r) => r > 0;
}
