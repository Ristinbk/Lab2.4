using System;
using System.Collections.Generic;

namespace Lab2
{
    public class Session : ISession
    {
        public List<IGroup> Groups { get; set; }
        public List<ISubject> Subjects { get; set; }
        public SessionType SessionType { get; }
        public int Year { get; }

        public Session(SessionType sessionType, int year)
        {
            SessionType = sessionType;
            Groups = new List<IGroup>();
            Subjects = new List<ISubject>();
            Year = year;
        }

        public void AddSubjects(List<ISubject> subjects)
        {
            if (subjects == null)
                throw new ArgumentNullException(nameof(subjects));
            Subjects.AddRange(subjects);
        }

        public void AddSubjectsInGroup(IGroup group)
        {
            if (group == null)
                throw new ArgumentNullException(nameof(group));
            Groups.Add(group);
            group.Students.ForEach(delegate (IStudent student)
            {
                student.AddSubjects(Subjects);
            });
        }

        public void AddSubjectsInStudent(IStudent student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));
            student.AddSubjects(Subjects);
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

        public override string ToString() => $"{SessionType} {Year}";     
    }
}
