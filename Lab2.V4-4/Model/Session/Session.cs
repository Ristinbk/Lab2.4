using System;
using System.Collections.Generic;

namespace Lab2
{
    public class Session : ISession
    {
        public List<IGroup> Groups { get; set; }
        public List<ISubject> Subjects { get; set; }
        public SessionType SessionType { get; }
        public string Specialty { get; }
        public int Year { get; }

        public Session(SessionType sessionType, int year, Specialty specialty)
        {
            SessionType = sessionType;
            Groups = new List<IGroup>();
            Subjects = new List<ISubject>();
            Year = year;
            Specialty = specialty.ToString().Substring(0,3);
        }

        public void AddSubjects(IGroup group, List<ISubject> subjects)
        {
            if (group == null)
                throw new ArgumentNullException(nameof(group));
            if (subjects == null)
                throw new ArgumentNullException(nameof(subjects));
            Subjects.AddRange(subjects);
            group.Students.ForEach(delegate (IStudent student)
            {
                student.AddSubjects(subjects);
            });
        }

        public void AddSubjects(IStudent student, List<ISubject> subjects)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));
            if (subjects == null)
                throw new ArgumentNullException(nameof(subjects));
            Subjects.AddRange(subjects);
            student.AddSubjects(subjects);

        }

        public void MoveToSubjectAssessment(IStudent student, ISubject subject, Assessment assessment)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));
            if (subject == null)
                throw new ArgumentNullException(nameof(subject));
            student.Subjects.Find(e => e.NameSubject == subject.NameSubject).AddAssessment(assessment);
        }

        public bool Equals(ISession other)
        {
            if (other != null && ToString().Equals(other.ToString()))
                return true;
            else
                return false;
        }

        public override string ToString() => $"{SessionType} {Year} {Specialty}";     
    }
}
