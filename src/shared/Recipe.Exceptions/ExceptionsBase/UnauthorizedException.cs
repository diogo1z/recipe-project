using System.Net;

namespace Recipe.Exceptions.ExceptionsBase;
public class UnauthorizedException : RecipeException
{
    public UnauthorizedException(string message) : base(message)
    {
    }

    public override IList<string> GetErrorMessages() => [Message];

    public override HttpStatusCode GetStatusCode() => HttpStatusCode.Unauthorized;
}