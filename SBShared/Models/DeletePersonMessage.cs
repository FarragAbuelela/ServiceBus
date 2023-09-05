using SBReceiver;
using SBShared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SBShared.Models
{
    public class DeletePersonMessage : IMessage<DeletePersonMessageDTO>
    {

        public void Invoke(DeletePersonMessageDTO deletePersonMessageDTO)
        {
            var person = PersonServices.Persons.FirstOrDefault(p => p.Id == deletePersonMessageDTO.PersonId);
            if (person != null)
            {
                PersonServices.Persons.Remove(person);
                Console.WriteLine($"This person is deleted => Name : {person.Name} , Age : {person.Age}");
            }
            else
            {
                Console.WriteLine("There is no person has this id !!!!");
            }
        }
    }
}
