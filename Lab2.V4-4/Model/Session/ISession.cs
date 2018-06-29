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
        void AddSubjects(IStudent student, List<ISubject> subjects);
        void MoveToSubjectAssessment(IStudent student, ISubject subject, Assessment assessment);
    }
}
