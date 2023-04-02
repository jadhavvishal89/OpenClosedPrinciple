
Open-Closed Principle(OCP) :It states that software entities (classes, modules, functions, etc.) should be open for extension but closed for modification. In other words, you should be able to add new functionality to a class without changing its existing code.

Suppose we have a Shape class with a method to calculate the area of the shape. We want to add support for new shapes, but we don’t want to modify the existing code for the Shape class. This is where the OCP comes into play.

Here’s an example code for the Shape class using the OCP:

public abstract class Shape {
    public abstract double CalculateArea();
}

public class Rectangle : Shape {
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea() {
        return Width * Height;
    }
}

public class Circle : Shape {
    public double Radius { get; set; }

    public override double CalculateArea() {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class ShapeCalculator {
    public double CalculateArea(Shape shape) {
        return shape.CalculateArea();
    }
}
In the above code, we define an abstract Shape class that has an abstract CalculateArea method. We then create concrete classes for each shape (e.g., Rectangle and Circle) that inherit from the Shape class and provide their own implementation for the CalculateArea method.

The ShapeCalculator class has a single public method, CalculateArea, that takes a Shape object and calls its CalculateArea method to calculate the area of the shape. Since the Shape class and its concrete subclasses are open for extension but closed for modification, we can add support for new shapes without modifying the existing code for the Shape and ShapeCalculator classes.

For example, to add support for a new Triangle shape, we can create a new Triangle class that inherits from the Shape class and provides its own implementation for the CalculateArea method:

public class Triangle : Shape {
    public double Base { get; set; }
    public double Height { get; set; }

    public override double CalculateArea() {
        return 0.5 * Base * Height;
    }
}
We can then use the ShapeCalculator class to calculate the area of a Triangle object:

ShapeCalculator calculator = new ShapeCalculator();
Triangle triangle = new Triangle { Base = 4, Height = 3 };
double area = calculator.CalculateArea(triangle);
As you can see, we were able to add support for a new Triangle shape without modifying the existing code for the Shape and ShapeCalculator classes, thanks to the OCP.

Reference ;-
https://medium.com/@CodewithChetan/solid-principles-838d615bfa1a