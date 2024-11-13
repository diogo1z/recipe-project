using System.Globalization;

namespace Recipe.API.Middleware;

public class CultureMiddleware {

    private readonly RequestDelegate _next;

    public CultureMiddleware (RequestDelegate next) {
        _next = next;
    }

    public async Task Invoke (HttpContext context) {
        var requestedCulture = context.Request.Headers.AcceptLanguage.FirstOrDefault ();

        var supportedLanguages = CultureInfo.GetCultures (CultureTypes.AllCultures).ToList ();

        var cultureInfo = new CultureInfo ("en");

        if (supportedLanguages.Exists (c => c.Name.Equals (requestedCulture))) {
            cultureInfo = new CultureInfo (requestedCulture);
        }

        CultureInfo.CurrentCulture = cultureInfo;
        CultureInfo.CurrentUICulture = cultureInfo;

        await _next (context);

    }
}