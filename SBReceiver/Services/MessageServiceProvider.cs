using SBReceiver.Interfaces;
using SBShared.DTOs;
using SBShared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SBReceiver.Services
{
    public class MessageServiceProvider : IMessageServiceProvider
    {
        private readonly IServiceProvider _serviceProvider;
        public MessageServiceProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public dynamic GetService(object receivedMessage)
        {
            Type messageType = receivedMessage.GetType();

            Type openType = typeof(IMessageHandler<>);
            Type closedType = openType.MakeGenericType(messageType);
            return _serviceProvider.GetService(closedType);
        }

    }
}
