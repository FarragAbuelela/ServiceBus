using SBShared.Const;
using SBShared.DTOs;
using SBShared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using static System.Collections.Specialized.BitVector32;

namespace SBReceiver
{
    public static class Deserializer
    {
        public static IMessageDTO GetObject(string message, Status action) {

            if (action == Status.DeletePerson)
                return JsonSerializer.Deserialize<DeletePersonMessageDTO>(message);
            else if (action == Status.AddPerson)
                return JsonSerializer.Deserialize<AddPersonMessageDTO>(message);
            else if (action == Status.UpdatePersonAge)
                return JsonSerializer.Deserialize<UpdateAgeMessageDTO>(message);
            else if(action == Status.UpdatePersonName)
                return JsonSerializer.Deserialize<UpdateNameMessageDTO>(message);
            else if(action == Status.PrintPersonsList)
                return JsonSerializer.Deserialize<PrintPersonsListMessageDTO>(message);
            return null;

        }
    }
}
