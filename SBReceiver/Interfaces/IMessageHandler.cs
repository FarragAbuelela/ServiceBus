using System;
using System.Collections.Generic;
using System.Text;

namespace SBReceiver.Interfaces
{
    public interface IMessageHandler<T>
    {
        bool CanBeHandledType(T type);
        void Invoke(T messsage);
    }

    public interface IMessageHandler : IMessageHandler<object>
    {
        void Invoke(object messsage);
    }
}
