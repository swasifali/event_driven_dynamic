//namespace ClientUI
//{
//    using System;
//    using System.Threading.Tasks;
//    using Contracts.Messages;
//    using NServiceBus;
//    using NServiceBus.Pipeline;

//    public class PublishFullTypeNameOnlyBehavior : IBehavior<IOutgoingPhysicalMessageContext, IOutgoingPhysicalMessageContext>
//    {
//        public Task Invoke(IOutgoingPhysicalMessageContext context, Func<IOutgoingPhysicalMessageContext, Task> next)
//        {
//            //if (context.Headers[Headers.MessageIntent] != "Publish")
//            //{
//            //    return next(context);
//            //}

//            var types = context.Headers[Headers.EnclosedMessageTypes];
//            var assemblyFullName = typeof(PlaceOrder).Assembly.FullName;
//            var enclosedTypes = types.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
//            for (var i = 0; i < enclosedTypes.Length; i++)
//            {
//                //enclosedTypes[i] = enclosedTypes[i].Replace($", {assemblyFullName}", string.Empty);
//                enclosedTypes[i] = Type.GetType(enclosedTypes[i])?.Name;
//            }
//            context.Headers[Headers.EnclosedMessageTypes] = string.Join(";", enclosedTypes);
//            return next(context);
//        }
//    }
//}