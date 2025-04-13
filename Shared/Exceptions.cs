
namespace Shared.Exceptions;

public class ExceptionResponse
{
    public required string Message { get; set; }
    public required int StatusCode { get; set; }
}

public class ApiException(ExceptionResponse exceptionResponse) : Exception
{
    public ExceptionResponse ExceptionResponse { get; set; } = exceptionResponse;
}
