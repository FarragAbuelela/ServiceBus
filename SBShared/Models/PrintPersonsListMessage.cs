using SBReceiver;
using SBShared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace SBShared.Models
{
    public class PrintPersonsListMessage : IMessage<PrintPersonsListMessageDTO>
    {
        public void Invoke(PrintPersonsListMessageDTO printPersonsListMessageDTO)
        {
            foreach (var item in PersonServices.Persons)
            {
                Console.WriteLine($" Name : {item.Name} , Age : {item.Age}");
            }
        }
    }
}
