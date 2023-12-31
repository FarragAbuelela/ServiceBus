﻿using SBReceiver.Services;
using SBShared.DTOs;
using System;
using System.Linq;

namespace SBReceiver.Messages
{
    public class UpdateAgeMessage : BaseMessageHandler<UpdateAgeMessageDTO>
    {
        public override void Invoke(UpdateAgeMessageDTO updateAgeMessageDTO)
        {
            if (!PersonServices.Persons.Any(p => p.Id == updateAgeMessageDTO.PersonId))
            {
                Console.WriteLine("this person does not exist !!!");
            }
            else
            {
                PersonServices.Persons.Where(p => p.Id == updateAgeMessageDTO.PersonId).FirstOrDefault().Age = updateAgeMessageDTO.NewAge;
                Console.WriteLine($"Age Updated => Name : {PersonServices.Persons.Where(p => p.Id == updateAgeMessageDTO.PersonId).FirstOrDefault().Name} , Age : {PersonServices.Persons.Where(p => p.Id == updateAgeMessageDTO.PersonId).FirstOrDefault().Age}");
            }
        }
    }
}
