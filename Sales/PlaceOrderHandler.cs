using System;
using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;
using Newtonsoft.Json;

namespace Sales
{
    using System.Dynamic;
    using Contracts.Messages;

    internal class PlaceOrderHandler :
        IHandleMessages<PlaceOrder>
    {
        static ILog log = LogManager.GetLogger<PlaceOrderHandler>();
        static Random random = new Random();

        public Task Handle(PlaceOrder message, IMessageHandlerContext context)
        {
            log.Info($"Received PlaceOrder, payload = {message.Payload}");

            // This is normally where some business logic would occur

            #region ThrowTransientException
            // Uncomment to test throwing transient exceptions
            //if (random.Next(0, 5) == 0)
            //{
            //    throw new Exception("Oops");
            //}
            #endregion

            #region ThrowFatalException
            // Uncomment to test throwing fatal exceptions
            //throw new Exception("BOOM");
            #endregion

            dynamic order = new ExpandoObject();
            switch (message.ContentType)
            {
                case "application/json":
                    order = JsonConvert.DeserializeObject<dynamic>(message.Payload as string);
                    break;

                default:
                    break;
            }
            
            var orderPlaced = new OrderPlaced
            {
                Payload = message.Payload,
                CustomData = order.OrderId,
                OrderCompletionDate = order.OrderDateTime
            };

            log.Info($"Publishing OrderPlaced, OrderId = {orderPlaced.CustomData}");

            return context.Publish(orderPlaced);
        }
    }
}
