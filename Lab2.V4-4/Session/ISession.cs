using System;
using System.Collections.Generic;

namespace Lab2
{
    public interface ISession : IEquatable<ISession>
    {
        List<ISubject> Subjects { get; }
        SessionType SessionType { get; }
        string Specialty { get; }           
        int Year { get; }

        void AddSubjects(IGroup Group, List<ISubject> subjects);
        void AddSubjects(IPerson person, List<ISubject> subjects);
        void MoveToSubjectAssessment(IPerson person, ISubject subject, Assessment assessment);
        void ShowSession();
        void ShowResultToGroup(IGroup group, ISubject subject);
    }
}
