using System.Collections.Generic;

namespace Lab2
{
    public interface ISession
    {
        List<ISubject> Subjects { get; }

        void AddSubjects(IGroup Group, List<ISubject> subjects);
        void moveAssessment(IPerson person, ISubject subject, Assessment assessment);
        void ShowSession(List<ISession> session);
    }
}
