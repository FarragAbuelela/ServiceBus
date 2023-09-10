using SBReceiver.Services;
using SBShared.DTOs;
using System;
using System.Linq;

namespace SBReceiver.Messages
{
    public class UpdateNameMessage : BaseMessageHandler<UpdateNameMessageDTO>
    {
        public override void Invoke(UpdateNameMessageDTO updateNameMessageDTO)
        {

            if (!PersonServices.Persons.Any(p => p.Id == updateNameMessageDTO.PersonId))
            {
                Console.WriteLine("this person does not exist !!!");
            }
            else
            {
                PersonServices.Persons.Where(p => p.Id == updateNameMessageDTO.PersonId).FirstOrDefault().Name = updateNameMessageDTO.NewName;
                Console.WriteLine($"Name Updated => Name : {PersonServices.Persons.Where(p => p.Id == updateNameMessageDTO.PersonId).FirstOrDefault().Name} , Age : {PersonServices.Persons.Where(p => p.Id == updateNameMessageDTO.PersonId).FirstOrDefault().Age}");
            }
        }
    }
}
