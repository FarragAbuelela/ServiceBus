using System;
using System.Collections.Generic;
using System.Text;

namespace SBReceiver.Interfaces
{
    public interface IMessageHandler
    {
        bool CanBeHandledType(object type);
        void Invoke(object messsage);
    }
    public interface IMessageHandler<T> : IMessageHandler
    {
        void Invoke(T messsage);
    }
}
