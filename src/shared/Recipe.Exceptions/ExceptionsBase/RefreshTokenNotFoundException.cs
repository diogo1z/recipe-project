﻿using System.Net;

namespace Recipe.Exceptions.ExceptionsBase;
public class RefreshTokenNotFoundException : RecipeException
{
    public RefreshTokenNotFoundException() : base(ResourceMessagesException.EXPIRED_SESSION)
    {
    }

    public override IList<string> GetErrorMessages() => new List<string> { Message };

    public override HttpStatusCode GetStatusCode() => HttpStatusCode.Unauthorized;
}
