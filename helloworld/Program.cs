class MyException : Exception
{
    public MyException(string str)
    {
        Console.WriteLine("User defined exception");
    }
}
class MyClient
{
    public static void Main()
    {
        try
        {
            throw new MyException("RAJESH");
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception caught here" + e.ToString());
        }
        Console.WriteLine("LAST STATEMENT");
    }
}
