using SBReceiver;
using SBReceiver.Services;
using SBShared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace SBShared.Models
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
