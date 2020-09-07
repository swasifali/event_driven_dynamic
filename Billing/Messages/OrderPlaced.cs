namespace Contracts.Messages
{
    using System;
    using NServiceBus;

    internal class OrderPlaced : GenericMessage, IEvent
    {
        //#region IGenericMessage Members

        //public object Payload { get; set; }
        //public string ContentType { get; set; }
        //public string Schema { get; set; }
        //public string Version { get; set; }

        //#endregion

        public string CustomData { get; set; }

        public DateTime? OrderCompletionDate { get; set; }
    }
}