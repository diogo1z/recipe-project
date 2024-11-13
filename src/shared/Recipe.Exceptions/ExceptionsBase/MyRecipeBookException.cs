using System.Net;

namespace Recipe.Exceptions.ExceptionsBase;
public abstract class RecipeException : SystemException
{
    protected RecipeException(string message) : base(message) { }

    public abstract IList<string> GetErrorMessages();
    public abstract HttpStatusCode GetStatusCode();
}
