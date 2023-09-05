using Microsoft.Azure.ServiceBus;
using SBReceiver.Interfaces;
using SBShared.Const;
using SBShared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace SBReceiver.Services
{
    public class MessageSerializer : IMessageSerializer
    {
        public object Serialize(Message message)
        {
            var jsonString = Encoding.UTF8.GetString(message.Body);
            Status action = (Status)message.UserProperties["Action"];
            if (action == Status.DeletePerson)
                return JsonSerializer.Deserialize<DeletePersonMessageDTO>(jsonString);
            else if (action == Status.AddPerson)
                return JsonSerializer.Deserialize<AddPersonMessageDTO>(jsonString);
            else if (action == Status.UpdatePersonAge)
                return JsonSerializer.Deserialize<UpdateAgeMessageDTO>(jsonString);
            else if (action == Status.UpdatePersonName)
                return JsonSerializer.Deserialize<UpdateNameMessageDTO>(jsonString);
            else if (action == Status.PrintPersonsList)
                return JsonSerializer.Deserialize<PrintPersonsListMessageDTO>(jsonString);
            throw new ArgumentNullException();
        }
    }
}
