namespace theatre_platform_server.kdomain.exception_handling.exceptions
{
    public class MyBadReqHttpException : AbstractMyHttpException
    {
        public MyBadReqHttpException(string message = "") : base(message, 400) { }
    }
}