namespace Contracts.Messages
{
    public abstract class GenericMessage
    {
        public object Payload { get; set; }

        public string ContentType { get; set; }

        public string Schema { get; set; }

        public string Version { get; set; }
    }
}
