namespace Application.Exceptions;

public class BadRequestException : ApplicationException
{
   public BadRequestException(string message, object Key) : base(message)
   {
        message = $"Entity with key {Key} not found";
    
   }
}