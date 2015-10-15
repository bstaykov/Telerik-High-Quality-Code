namespace ConsoleWebServer.Framework
{
    using System.Collections.Generic;

    public class ContentActionResultWithoutCaching : ContentActionResult
    {
        private const string CacheControlHeader = "Cache-Control";
        private const string CacheControllesettings = "private, max-age=0, no-cache";

        public ContentActionResultWithoutCaching(HttpRequest request, object model)
            : base(request, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>(CacheControlHeader, CacheControllesettings));
        }
    }
}
