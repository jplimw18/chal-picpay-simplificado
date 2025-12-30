namespace PicpayChal.App.Exceptions;

public sealed class InvalidTransactionException : Exception
{
    public InvalidTransactionException(string message)
        : base(message) {  }
}
