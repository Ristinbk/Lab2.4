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
            group.Persons.ForEach(delegate (IPerson student)
            {
                foreach (var t in subjects)
                {
                    student.AddSubject(t);
                }
            });
        }

        public void AddSubjects(IPerson person, List<ISubject> subjects)
        {
            if (person == null)
                throw new ArgumentNullException(nameof(person));
            if (subjects == null)
                throw new ArgumentNullException(nameof(subjects));
            Subjects.AddRange(subjects);
            foreach (var t in subjects)
            {
                person.AddSubject(t);
            }
        }

        public void MoveToSubjectAssessment(IPerson person, ISubject subject, Assessment assessment)
        {
            if (person == null)
                throw new ArgumentNullException(nameof(person));
            if (subject == null)
                throw new ArgumentNullException(nameof(subject));
            person.Subjects.Find(e => e.NameSubject == subject.NameSubject).AddAssessment(assessment);
        }

        public void ShowSession()
        {
            Console.WriteLine(ToString());
            foreach (var t in Subjects)
            {
                Console.WriteLine(t.ToString());
            }
        }

        public void ShowResultToGroup(IGroup group, ISubject subject)
        {
            if (group == null)
                throw new ArgumentNullException(nameof(group));
            if (subject == null)
                throw new ArgumentNullException(nameof(subject));
            Console.WriteLine(ToString());
            Console.WriteLine(subject.NameSubject + " " + subject.SubjectType + " " + group.NumberGroup);
            group.Persons.ForEach(delegate (IPerson person)
            {
                person.ShowSubject(subject);
            });
        }

        public void ShowResultToPerson(IPerson person, ISubject subject)
        {
            person.ShowAllSubjects();
        }

        public bool Equals(ISession other)
        {
            if (other != null && ToString().Equals(other.ToString()))
                return true;
            else
                return false;
        }

        public override string ToString() => $"{SessionType} session {Year} {Specialty}";     
    }
}
