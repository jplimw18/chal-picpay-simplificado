namespace PicpayChal.App.Exceptions;

public sealed class InvalidTransactionException : Exception
{
    public InvalidTransactionException(string message)
        : base($"Invalid Transaction - {message}") {  }
}
