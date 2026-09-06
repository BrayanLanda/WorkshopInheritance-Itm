namespace Backend;

public class Parallelogram : Rectangle
{
    private double _h;

    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
    }

    public double H
    {
        get => _h;
        set
        {
            if (!ValidateH(value))
                throw new ArgumentException("Height must be greater than 0.");
            _h = value;
        }
    }

    public override double GetArea()
    {
        return B * H;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private bool ValidateH(double h) => h > 0;
}
