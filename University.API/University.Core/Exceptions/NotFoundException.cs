namespace University.Core.Exceptions
{
    public class NotFoundException : Exception
    {

        public NotFoundException() : base("Requested record not found")
        {

        }
        public NotFoundException(string message) : base(message)
        {

        }
        
    }
}
