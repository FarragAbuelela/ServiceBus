using Microsoft.Azure.ServiceBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace SBReceiver.Interfaces
{
    public interface IService
    {
        void Invoke(Message message);
    }
}
