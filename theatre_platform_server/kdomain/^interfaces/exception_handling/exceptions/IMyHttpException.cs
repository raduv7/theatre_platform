namespace theatre_platform_server.kdomain._interfaces.exception_handling.exceptions
{
    public interface IMyHttpException
    {
        // public constructor required for non-abstract classes !!

        int Code { get; }
        string Message { get; }
        string StackTrace { get; }
    }
}