namespace Laba8
{
    public class StackHandlerArgs
    {
        private readonly string _message;
        private readonly object _sender;

        public string Message => _message;
        public object Sender => _sender;

        public StackHandlerArgs(string message, object sender)
        {
            _message = message;
            _sender = sender;
        }
    }
}