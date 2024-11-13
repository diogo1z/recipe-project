using System.Net;

namespace Recipe.Exceptions.ExceptionsBase;

public class InvalidLoginException : RecipeException
{
    public InvalidLoginException() : base(ResourceMessagesException.EMAIL_OR_PASSWORD_INVALID)
    {
    }

    public override IList<string> GetErrorMessages() => new List<string> { Message };

    public override HttpStatusCode GetStatusCode() => HttpStatusCode.Unauthorized;
}
