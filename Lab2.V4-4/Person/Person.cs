using System;
using System.Collections.Generic;

namespace Lab2
{
    public abstract class Person : IPerson
    {
        public FullName Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public abstract string Id { get; set; }
        protected List<ISubject> subjects;
        public List<ISubject> Subjects { get { return subjects; } }

        public Person(FullName name, DateTime birthDate, Gender Gender)
        {
            Name = name;
            Gender = (Gender)Enum.Parse(typeof(Gender), this.Gender.ToString(), true);
            DateOfBirth = default(DateTime);
            subjects = new List<ISubject>();
        }

        public abstract void SetId(int id);
        public abstract void ShowPerson();
        public void AddSubject(ISubject subject) => subjects.Add(new Subject(subject.NameSubject, subject.SubjectType, subject.Teacher));

        public void AddSubjects(List<ISubject> subjects)
        {
            for (int i = 0; i < subjects.Count; i++)
            {
                this.subjects.Add(new Subject(subjects[i].NameSubject, subjects[i].SubjectType, subjects[i].Teacher));
            }            
        }

        public void ShowAllPerson(List<IPerson> person)
        {
            foreach (IPerson f in person)
            {
                f.ShowPerson();
            }
        }
    }
}
