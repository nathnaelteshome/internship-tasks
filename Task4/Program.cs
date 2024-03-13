Circle circle = new Circle { Name = "Ellipse", Radius = 2 };
Rectangle rectangle = new Rectangle { Name = "Square", Width = 2, Height = 3 };
Triangle triangle = new Triangle { Name = "Iso-Triangle", Base = 2, Height = 3 };

Console.Write($"I am {circle.Name} and my  area is {circle.CalculateArea()}\n");
Console.Write($"I am {rectangle.Name} and my  area is {rectangle.CalculateArea()}\n");
Console.Write($"I am {triangle.Name} and my  area is {triangle.CalculateArea()}");


public class Shape
{
    public string Name;

    public virtual double CalculateArea()
    {
        return 0; 
    }
}

public class Circle: Shape
{
    public double Radius;

    public override double CalculateArea()
    {
        return 3.14 * Radius * Radius;
    }
}

public class Rectangle: Shape
{
    public double Width;
    public double Height;

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

public class Triangle : Shape
{
    public double Base;
    public double Height;

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

