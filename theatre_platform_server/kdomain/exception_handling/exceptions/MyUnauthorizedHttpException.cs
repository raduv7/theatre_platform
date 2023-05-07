namespace theatre_platform_server.kdomain.exception_handling.exceptions
{
    public class MyUnauthorizedHttpException : AbstractMyHttpException
    {
        public MyUnauthorizedHttpException(string message = "") : base(message, 401) { }
    }
}