using System;
using System.Collections.Generic;

namespace Lab2
{
    public abstract class Person : IPerson
    {
        public FullName Name { get; set; }
        public DateTime DateBirthday { get; set; }  
        public Id Id { get; set; }
        public List<ISubject> Subjects { get; set; }

        protected Person(FullName name, DateTime dateBirthday)
        {
            Name = name;
            DateBirthday = dateBirthday;
            Subjects = new List<ISubject>();
            Id = new Id();
        }
    }
}
