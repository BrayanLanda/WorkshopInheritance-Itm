namespace Backend;

public class Triangle : Rectangle
{
    private double _c;
    private double _h;
    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        C = c;
        H = h;
    }
    public double C { 
        get => _c; 
        set
        {
            if (!ValidateC(value))
                throw new ArgumentException("Side C must be greater than 0.");
            _c = value;
        }
    }
    public double H { 
        get => _h; 
        set
        {
            if (!ValidateH(value))
                throw new ArgumentException("Height must be greater than 0.");
            _h = value;
        }
    }
    public override double GetArea() => (B * H) / 2;
    public override double GetPerimeter() => A + B + C;
    private bool ValidateC(double c) => c > 0;
    private bool ValidateH(double h) => h > 0;
}
