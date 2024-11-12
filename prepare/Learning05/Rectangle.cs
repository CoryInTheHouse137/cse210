

class Rectangle : Shape
{
    private double _lenth;
    private double _width;

    public Rectangle(string color, double lenth, double width) : base(color)
    {
        _color = color;
        _lenth = lenth;
        _width = width;
    }
  
    public override double GetArea()
    {
        return _lenth * _width;
    }

}