﻿
Rectangle rectangle = new Rectangle (name: "Square", width: 2, height: 3 );
Circle circle = new Circle ( name: "Ellipse",  radius: 2 );
Triangle triangle = new Triangle ( name: "Iso-Triangle", baseHeight: 2, height: 3 );

Console.Write($"I am {circle.Name} and my  area is {circle.CalculateArea()}\n");
Console.Write($"I am {rectangle.Name} and my  area is {rectangle.CalculateArea()}\n");
Console.Write($"I am {triangle.Name} and my  area is {triangle.CalculateArea()}");

public abstract class Shape(string name)
{
    public string Name {get; set;} = name;

    public abstract double CalculateArea();
}

public class Circle(double radius, string name): Shape(name)
{
    public double Radius {get; set;} = radius;

    public override double CalculateArea()
    {
        return 3.14 * Radius * Radius;
    }
}

public class Rectangle(string name, double width, double height): Shape(name)
{
    public double Width {get; set;} = width;
    public double Height {get; set; } = height;

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

public class Triangle(string name, double baseHeight, double height) : Shape(name)
{
    public double Base {get; set;} = baseHeight;
    public double Height {get; set;} = height;

    public override double CalculateArea()
    {
        return (Base * Height) / 2;
    }
}




// Previous Code with out constructors and properties exposed to public


// Circle circle = new Circle { Name = "Ellipse", Radius = 2 };
// Rectangle rectangle = new Rectangle { Name = "Square", Width = 2, Height = 3 };
// Triangle triangle = new Triangle { Name = "Iso-Triangle", Base = 2, Height = 3 };

// Console.Write($"I am {circle.Name} and my  area is {circle.CalculateArea()}\n");
// Console.Write($"I am {rectangle.Name} and my  area is {rectangle.CalculateArea()}\n");
// Console.Write($"I am {triangle.Name} and my  area is {triangle.CalculateArea()}");


// public abstract class Shape
// {
//     public string Name;

//     public abstract double CalculateArea();
//     
// }

// public class Circle: Shape
// {
//     public double Radius;

//     public override double CalculateArea()
//     {
//         return 3.14 * Radius * Radius;
//     }
// }

// public class Rectangle: Shape
// {
//     public double Width;
//     public double Height;

//     public override double CalculateArea()
//     {
//         return Width * Height;
//     }
// }

// public class Triangle : Shape
// {
//     public double Base;
//     public double Height;

//     public override double CalculateArea()
//     {
//         return (Base * Height) / 2;
//     }
// }

