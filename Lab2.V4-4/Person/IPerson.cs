using System;
using System.Collections.Generic;

namespace Lab2
{
    public interface IPerson
    {        
        FullName Name { get; set; }
        DateTime DateOfBirth { get; set; }
        Gender Gender { get; set; }
        Id Id { get; set; }
        List<ISubject> Subjects { get; }

        void AddSubject(ISubject subject);
        void ShowSubject(ISubject subject);
        void ShowAllSubjects();
    }
}
