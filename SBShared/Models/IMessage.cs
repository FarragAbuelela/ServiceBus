using SBShared.Const;
using System;
using System.Collections.Generic;
using System.Text;

namespace SBShared.Models
{
    public interface IMessage<T> where T : class
    {
        void Invoke(T message);
    }
}
