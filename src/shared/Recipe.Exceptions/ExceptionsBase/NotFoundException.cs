using System.Net;

namespace Recipe.Exceptions.ExceptionsBase;
public class NotFoundException : RecipeException
{
    public NotFoundException(string message) : base(message)
    {
    }

    public override IList<string> GetErrorMessages() => new List<string> { Message };

    public override HttpStatusCode GetStatusCode() => HttpStatusCode.NotFound;
}