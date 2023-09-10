using SBReceiver.Services;
using SBShared.DTOs;
using SBShared.Models;
using System;
using System.Linq;

namespace SBReceiver.Messages
{
    public class AddPersonMessage : BaseMessageHandler<AddPersonMessageDTO>
    {
        public override void Invoke(AddPersonMessageDTO addPersonMessageDTO)
        {
            if (addPersonMessageDTO != null)
            {
                Console.WriteLine("Message is null !!");
            }
            if (PersonServices.Persons.Any(p => p.Id == addPersonMessageDTO.PersonId))
            {
                Console.WriteLine("this person already added !!!");
            }
            else
            {
                PersonServices.Persons.Add(new Person() { Id = addPersonMessageDTO.PersonId, Age = addPersonMessageDTO.Age, Name = addPersonMessageDTO.Name });
                Console.WriteLine($"New person Added => Name : {PersonServices.Persons.Where(p => p.Id == addPersonMessageDTO.PersonId).FirstOrDefault().Name} , Age : {PersonServices.Persons.Where(p => p.Id == addPersonMessageDTO.PersonId).FirstOrDefault().Age}");
            }
        }

        
    }
}
