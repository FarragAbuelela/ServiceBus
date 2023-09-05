using SBShared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SBReceiver
{
    public class PersonServices
    {
        public static List<Person> Persons = new List<Person>()
        {
            new Person()
            {
                Id = 1,
                Name= "test",
                Age = 1
            },
            new Person()
            {
                Id = 2,
                Name= "test1",
                Age = 2
            },
            new Person()
            {
                Id = 3,
                Name= "test3",
                Age = 3
            },
            new Person()
            {
                Id = 4,
                Name= "test4",
                Age = 4
            }
        };
    }
}
