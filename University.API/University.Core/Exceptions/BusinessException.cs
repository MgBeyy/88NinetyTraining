namespace University.Core.Exceptions
{
    public class BusinessException : Exception
    {

        public Dictionary<string, List<string>> Errors { get; set; }
        public BusinessException(string message) : base(message)
        {
            Errors = new Dictionary<string, List<string>>();
        }

        public BusinessException(Dictionary<string, List<string>> _errors)
        {
            Errors = _errors ?? new Dictionary<string, List<string>>();
        }
    }
}


