using System;
using System.Collections.Generic;

namespace Lab2
{
    public class Subject : ISubject
    {
        public IPerson Teacher { get; set; }
        public SubjectType SubjectType { get; set; }
        public Assessment Assessment { get; private set; }
        public string NameSubject { get; set; }

        protected Subject(string nameSubject) : this(nameSubject, new SubjectType()) { }

        public Subject(string nameSubject, SubjectType subjectType)
        {
            NameSubject = nameSubject;
            SubjectType = subjectType;
            Assessment = Assessment.None;
        }

        public Subject(string nameSubject, SubjectType subjectType, IPerson Teacher)
        {
            NameSubject = nameSubject;
            SubjectType = subjectType;
            Assessment = Assessment.None;
            this.Teacher = Teacher;
        }

        public void AddTeacher(IPerson teacher) => Teacher = teacher ?? throw new ArgumentException("invalid teacher");
        public ISubject GetSubject(ISubject subject) => subject;
        public void AddAssessment(Assessment assessment) => Assessment = assessment;
        public override string ToString() => $"{NameSubject} ({SubjectType})";
        public void ShowSubject() => Console.WriteLine(NameSubject + "\t" + Teacher.Name + "\t" + SubjectType);

        public void ShowAllSubjects(List<ISubject> subjects)
        {
            foreach (ISubject f in subjects)
            {
                f.ShowSubject();
            }
        }
    }
}
