using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
    
        Shape cShape = new Circle("Blue",1);
        Shape rShape = new Rectangle("Red",3,5);
        Shape sShape = new Square("Yellow",4);

        shapes.Add(cShape);
        shapes.Add(rShape);
        shapes.Add(sShape);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"This shape is {shape.GetColor()}, the area is: {shape.GetArea()}");
        }

    }
}