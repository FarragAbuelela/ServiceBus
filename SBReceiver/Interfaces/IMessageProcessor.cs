using System;
using System.Collections.Generic;
using System.Text;

namespace SBReceiver.Interfaces
{
    public interface IMessageProcessor
    {
        Type Process(object message);
    }
}
