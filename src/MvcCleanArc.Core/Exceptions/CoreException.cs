namespace MvcCleanArc.Core.Exceptions;

public class CoreException : Exception
{
    internal CoreException(string? message) : base(message)
    {
    }
    public CoreException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

}
