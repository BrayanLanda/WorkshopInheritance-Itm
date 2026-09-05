namespace Backend;

public class Rectangle : Square
{
    private double _b;

    public Rectangle(string name, double a, double b) : base(name, a)
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
        return A * B;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private bool ValidateB(double b) => b > 0;
}
