using SBReceiver.Interfaces;
using SBShared.Models;

namespace SBReceiver.Services
{
    public abstract class BaseMessageHandler <T> : IMessageHandler<T> where T : class
    {
        public bool CanBeHandledType(T type)
        {
            return type.GetType() == typeof(IMessage<>);
        }

        public abstract void Invoke(T message);


    }
}
