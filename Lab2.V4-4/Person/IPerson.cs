using System;
using System.Collections.Generic;

namespace Lab2
{
    public interface IPerson
    {
        string Id { get; set; }
        FullName Name { get; set; }
        DateTime DateOfBirth { get; set; }
        Gender Gender { get; set; }
        List<ISubject> Subjects { get; }

        void SetId(int id);
        void AddSubject(ISubject subject);
        void AddSubjects(List<ISubject> subjects);
        void ShowPerson();
        void ShowAllPerson(List<IPerson> person);
    }
}
