using System;
using System.Collections.Generic;

namespace Lab2
{
    public abstract class Person : IPerson
    {
        public FullName Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Id Id { get; set; }
        public List<ISubject> Subjects { get; } 

        public Person(FullName name, DateTime birthDate, Gender Gender)
        {
            Name = name;
            this.Gender = Gender;
            DateOfBirth = birthDate;
            Subjects = new List<ISubject>();
            Id = new Id();
        }

        public void AddSubject(ISubject subject)
        {
            if (subject == null)
                throw new ArgumentNullException(nameof(subject));
            Subjects.Add(new Subject(subject.NameSubject, subject.SubjectType, subject.NameTeacher));
        }

        public void ShowSubject(ISubject subject)
        {
            if (subject == null)
                throw new ArgumentNullException(nameof(subject));
            Console.WriteLine(Name + "\t- "  + Subjects.Find(s => s.NameSubject.Equals(subject.NameSubject)));
        }

        public void ShowAllSubjects()
        {
            Console.WriteLine(ToString());
            foreach (var s in Subjects)
            {
                Console.WriteLine(s.NameSubject + "\t(" + s.SubjectType + ")\t- " + s.Assessment);
            }
        }
    }
}
