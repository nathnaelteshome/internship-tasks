MyClass.Print();

public class MyClass
{
    static MyClass()
    {
        Console.WriteLine("Static Constructor");
    }

    public static void Print()
    {
        Console.WriteLine("Print Method");
    }
}

