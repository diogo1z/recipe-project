using System.Net;

namespace Recipe.Exceptions.ExceptionsBase;
public class RefreshTokenExpiredException : RecipeException
{
    public RefreshTokenExpiredException() : base(ResourceMessagesException.INVALID_SESSION)
    {
    }

    public override IList<string> GetErrorMessages() => new List<string> { Message };

    public override HttpStatusCode GetStatusCode() => HttpStatusCode.Forbidden;
}
