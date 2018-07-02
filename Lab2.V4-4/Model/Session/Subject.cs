using System;
using System.Collections.Generic;

namespace Lab2
{
    public class Subject : ISubject
    {
        public string NameTeacher { get; set; }
        public SubjectType SubjectType { get; set; }
        public Assessment Assessment { get; private set; }
        public string NameSubject { get; set; }

        public Subject(string nameSubject, SubjectType subjectType)
        {
            NameSubject = nameSubject;
            SubjectType = subjectType;
            Assessment = Assessment.None;
        }

        public Subject(string nameSubject, SubjectType subjectType, string  nameTeacher)
        {
            NameSubject = nameSubject;
            SubjectType = subjectType;
            Assessment = Assessment.None;
            NameTeacher = nameTeacher;
        }

        public void AddTeacher(ITeacher teacher)
        {
            if (teacher == null)
                throw new ArgumentNullException(nameof(teacher));
            NameTeacher = teacher.Name.ToString() ?? throw new ArgumentException("invalid teacher");
            teacher.AddSubject(this);
        }

        public ISubject GetSubject(ISubject subject)
        {
            if (subject == null)
                throw new ArgumentNullException(nameof(subject));
            return subject;
        }

        public void AddAssessment(Assessment assessment) => Assessment = assessment;

        public bool Equals(ISubject other)
        {
            if (other != null && NameSubject.ToString().Equals(other.NameSubject.ToString()))
                return true;
            else
                return false;
        }

        public override string ToString() => $"{NameSubject}";
    }
}
