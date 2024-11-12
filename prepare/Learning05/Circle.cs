

class Circle : Shape
{
    private double _radius ;

    public Circle(string color, double radius) : base(color)
    {
        _color = color;
        _radius = radius;
    }

    public override double GetArea()
    {
        double p = Math.PI;
        return p * _radius * _radius;
    }

}