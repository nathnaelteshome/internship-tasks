Rectangle rectangle = new Rectangle (name: "Square", width: 2, height: 3 );
Circle circle = new Circle ( name: "Ellipse",  radius: 2 );
Triangle triangle = new Triangle ( name: "Iso-Triangle", baseWidth: 2, height: 3 );

Console.Write($"I am {circle.Name} and my  area is {circle.CalculateArea()}\n");
Console.Write($"I am {rectangle.Name} and my  area is {rectangle.CalculateArea()}\n");
Console.Write($"I am {triangle.Name} and my  area is {triangle.CalculateArea()}");


public class Shape
{
    public string Name{ get; set;}

    public virtual double CalculateArea()
    {
        return 0; 
    }
}

public class Circle: Shape
{
    public double Radius;

    public Circle(string name, double radius){
        Name = name;
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return 3.14 * Radius * Radius;
    }
}

public class Rectangle: Shape
{
    public double Width;
    public double Height;
    public Rectangle(string name, double height, double width){
        Name = name;
        Height = height;
        Width = width;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

public class Triangle : Shape
{
    public double Base;
    public double Height;

    public Triangle(string name, double height, double baseWidth){
        Name = name;
        Height = height;
        Base = baseWidth;
    }

    public override double CalculateArea()
    {
        return (Base * Height) / 2;
    }
}




// Previous Code


// Circle circle = new Circle { Name = "Ellipse", Radius = 2 };
// Rectangle rectangle = new Rectangle { Name = "Square", Width = 2, Height = 3 };
// Triangle triangle = new Triangle { Name = "Iso-Triangle", Base = 2, Height = 3 };

// Console.Write($"I am {circle.Name} and my  area is {circle.CalculateArea()}\n");
// Console.Write($"I am {rectangle.Name} and my  area is {rectangle.CalculateArea()}\n");
// Console.Write($"I am {triangle.Name} and my  area is {triangle.CalculateArea()}");


// public class Shape
// {
//     public string Name;

//     public virtual double CalculateArea()
//     {
//         return 0; 
//     }
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

