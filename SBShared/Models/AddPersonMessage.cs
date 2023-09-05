using SBReceiver;
using SBShared.DTOs;
using System;
using System.Linq;

namespace SBShared.Models
{
    public class AddPersonMessage : IMessage<AddPersonMessageDTO>
    {
        public void Invoke(AddPersonMessageDTO addPersonMessageDTO)
        {
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
