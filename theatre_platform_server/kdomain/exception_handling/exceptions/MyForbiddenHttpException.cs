namespace theatre_platform_server.kdomain.exception_handling.exceptions
{
    public class MyForbiddenHttpException : AbstractMyHttpException
    {
        public MyForbiddenHttpException(string message = "") : base(message, 403) { }
    }
}