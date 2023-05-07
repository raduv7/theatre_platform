namespace theatre_platform_server.kdomain.exception_handling.exceptions
{
    public class MyCoffeeHttpException : AbstractMyHttpException
    {
        public MyCoffeeHttpException(string message = "") : base(message, 418) {}
    }
}