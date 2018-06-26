using System.Collections.Generic;

namespace Lab2
{
    public interface ISubject
    {
        string NameTeacher { get; set; }
        SubjectType SubjectType { get; set; }
        Assessment Assessment { get; }
        string NameSubject { get; set; }

        void AddTeacher(IPerson teacher);
        ISubject GetSubject(ISubject subject);
        void AddAssessment(Assessment assessment);
    }
}
