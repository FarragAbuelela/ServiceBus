using System;
using System.Collections.Generic;
using System.Text;

namespace SBReceiver.Interfaces
{
    public interface IMessageServiceProvider
    {
        dynamic GetService(object receivedMessage);
    }
}
