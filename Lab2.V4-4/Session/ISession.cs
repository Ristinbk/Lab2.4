using System.Collections.Generic;

namespace Lab2
{
    public interface ISession
    {
        SessionType SessionType { get; }
        int Year { get; }
        List<ISubject> Subjects { get; }

        void AddSubjects(IGroup Group, List<ISubject> subjects);
        void MoveToSubjectAssessment(IPerson person, ISubject subject, Assessment assessment);
        void ShowSession();
        void ShowResultToGroup(IGroup group, ISubject subject);
    }
}
