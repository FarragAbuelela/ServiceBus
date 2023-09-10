using SBReceiver.Services;
using SBShared.DTOs;
using System;

namespace SBReceiver.Messages
{
    public class PrintPersonsListMessage : BaseMessageHandler<PrintPersonsListMessageDTO>
    {
        public override void Invoke(PrintPersonsListMessageDTO printPersonsListMessageDTO)
        {
            foreach (var item in PersonServices.Persons)
            {
                Console.WriteLine($" Name : {item.Name} , Age : {item.Age}");
            }
        }
    }
}
