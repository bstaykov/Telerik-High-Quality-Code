namespace ConsoleWebServer.Framework.Interfaces
{
    public interface IResponseProvider
    {
        HttpResponse GetResponse(string requestAsString);
    }
}