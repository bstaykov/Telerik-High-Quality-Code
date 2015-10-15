namespace ConsoleWebServer.Framework
{
    using System;
    using System.Linq;

    public class HttpNotFound : Exception
    {
        public HttpNotFound(string message) 
            : base(message) 
        {
        }
    }
}