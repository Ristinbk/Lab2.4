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

        public void AddSubjects(IGroup group, List<ISubject> subjects)
        {
            if (group == null)
                throw new ArgumentNullException(nameof(group));
            if (subjects == null)
                throw new ArgumentNullException(nameof(subjects));
            Subjects.AddRange(subjects);
            //    Subjects = subjects ?? throw new ArgumentNullException(nameof(subjects));
            group.Persons.ForEach(delegate (IPerson student)
            {
                foreach (var t in subjects)
                {
                    student.AddSubject(t);
                }
            });
        }

        public void MoveToGroupSession(IGroup group, ISession session)
        {
            Groups.Add(group);
            AddSubjects(group, session.Subjects);
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

        public override string ToString() => $"{SessionType} session {Year}";
    }
}
