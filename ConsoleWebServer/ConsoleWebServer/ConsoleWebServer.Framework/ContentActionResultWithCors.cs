namespace ConsoleWebServer.Framework
{
    using System.Collections.Generic;

    public class ContentActionResultWithCors<TResult> : ContentActionResult
    {
        private const string AccessControllAllowOriginHeader = "Access-Control-Allow-Origin";

        public ContentActionResultWithCors(HttpRequest request, object model, string corsSettings)
            : base(request, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>(AccessControllAllowOriginHeader, corsSettings));
        }
    }
}
