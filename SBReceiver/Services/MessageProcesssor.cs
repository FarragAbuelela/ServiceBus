using SBReceiver.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SBReceiver.Services
{
    public class MessageProcesssor : IMessageProcessor
    {
        public Type Process(object message)
        {
            return message.GetType();
        }
    }
}
