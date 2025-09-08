namespace SchoolApp.Exceptions
{
    public class InvalidArgumentException : AppException
    {
        private static readonly string DEFAULT_CODE = "Invalid Argument";

        public InvalidArgumentException(string code, string message) : base(code + DEFAULT_CODE, message)
        {

        }
    }
}
