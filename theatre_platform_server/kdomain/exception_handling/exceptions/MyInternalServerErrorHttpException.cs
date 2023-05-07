namespace theatre_platform_server.kdomain.exception_handling.exceptions
{
    public class MyInternalServerErrorHttpException : AbstractMyHttpException
    {
        public MyInternalServerErrorHttpException(string message = "") : base(message, 500) { }
    }
}