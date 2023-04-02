internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Open-Closed Principle");

        ShapeCalculator shapeCalculator = new ShapeCalculator();
        Rectangle rectangle= new Rectangle { Height=3,Width=3 };
        var rectanglrArea= shapeCalculator.CalculateArea(rectangle);
        Console.WriteLine($"rectanglr Area={rectanglrArea}");


        Circle circle = new Circle { radius = 3 };
        var circleArea = shapeCalculator.CalculateArea(circle);
        Console.WriteLine($"circle Area={circleArea}");
    }
}

public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    public double radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI* Math.Pow(radius,2);
    }
}

class ShapeCalculator 
{
    public double CalculateArea(Shape shape)
    { return shape.CalculateArea(); }
}