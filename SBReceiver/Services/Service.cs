using Microsoft.Azure.ServiceBus;
using SBReceiver.Interfaces;
using SBShared.Const;
using System;
using System.Text;

namespace SBReceiver.Services
{
    public class Service : IService
    {
        private readonly IMessageServiceProvider _messageServiceProvider;
        private readonly IMessageSerializer _messageSerializer;
        public Service(IMessageServiceProvider messageServiceProvider, IMessageSerializer messageSerializer)
        {
            _messageServiceProvider = messageServiceProvider;
            _messageSerializer = messageSerializer;
        }

        public void Invoke(Message message)
        {

            object deserializedMessage = _messageSerializer.Serialize(message);
            var service = _messageServiceProvider.GetService(deserializedMessage);
            service.Invoke((dynamic)deserializedMessage);






/*
            var jsonString = Encoding.UTF8.GetString(message.Body);
            Status action = (Status)message.UserProperties["Action"];

            var receivedMessage = Deserializer.GetObject(jsonString, action);
            if (receivedMessage == null)
            {
                Console.WriteLine("Null Message!!!!");
            }
            else
            {
                var service = _messageServiceProvider.GetService(receivedMessage);
                if (service is null)
                {
                    Console.WriteLine("No service found for this message type: " + receivedMessage.GetType());
                }
                else service.Invoke((dynamic)receivedMessage);
                
            }*/
        }

    }
}
