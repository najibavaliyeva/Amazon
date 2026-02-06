

namespace Amazon.Exceptions.NotFoundException
{
    public class NotFoundException : System.Exception
    {
        public NotFoundException(string? message) : base($"{message} was not found")
        {
        }
    }
}
