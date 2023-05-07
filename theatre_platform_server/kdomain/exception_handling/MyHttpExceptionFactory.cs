using theatre_platform_server.kdomain.exception_handling.exceptions;
using theatre_platform_server.kdomain.interfaces.exception_handling;

namespace theatre_platform_server.kdomain.exception_handling
{
    public class MyHttpExceptionFactory : IMyHttpExceptionFactory
    {
        public static MyBadReqHttpException CreateBadReqException(string message = "Bad request")
        {
            return new MyBadReqHttpException(message);
        }

        public static MyUnauthorizedHttpException CreateUnauthorizedException(string message = "Unauthorized request")
        {
            return new MyUnauthorizedHttpException(message);
        }

        public static MyForbiddenHttpException CreateForbiddenException(string message = "Forbidden request")
        {
            return new MyForbiddenHttpException(message);
        }
        
        public static MyCoffeeHttpException CreateCoffeeException(string message = "I'm a teapot / Sir, bring me a coffee!")
        {
            return new MyCoffeeHttpException(message);
        }

        public static MyInternalServerErrorHttpException CreateInternalServerErrorException(
            string message = "Internal server error")
        {
            return new MyInternalServerErrorHttpException(message);
        }
    }
}