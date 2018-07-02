using System;
using System.Collections.Generic;

namespace Lab2
{
    public interface ISession : IEquatable<ISession>
    {
        List<IGroup> Groups { get; set; }
        List<ISubject> Subjects { get; }
        SessionType SessionType { get; }           
        int Year { get; }

        void AddSubjects(List<ISubject> subjects);
        void AddSubjectsInGroup(IGroup Group);
        void AddSubjectsInStudent(IStudent student);
        void MoveToSubjectAssessment(IStudent student, ISubject subject, Assessment assessment);
    }
}
