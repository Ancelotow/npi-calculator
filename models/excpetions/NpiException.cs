namespace npi_calculator.models.excpetions;

public class NpiException : Exception
{
    public NpiExceptionCode Code { get; }

    public NpiException(string message, NpiExceptionCode code) : base(message)
    {
        Code = code;
    }
}