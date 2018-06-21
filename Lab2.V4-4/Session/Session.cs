using System.Collections.Generic;

namespace Lab2
{
    public class Session :ISession
    {
        public List<IGroup> Groups { get; }
        public List<ISubject> Subjects { get; }
        public SessionType SessionType { get; }

        public  Session(SessionType sessionType, List<IGroup> groups)
        {
            SessionType = sessionType;
            Groups = groups;
            Subjects = new List<ISubject>();
        }

        public void AddSubjects(IGroup Group, List<ISubject> subjects)
        {
            Group.Persons.ForEach(delegate (IPerson student)
            {
                student.AddSubjects(subjects);
                //foreach (var s in subjects)
                //{
                //    student.AddSubject(s);
                //}
            });
            //foreach (var t in Group.Persons)
            //{
            //    t.AddSubjects(subjects);
            //}
        }

        public void moveAssessment(IPerson person, ISubject subject, Assessment assessment)
        {
         //   foreach (var t in Groups)
         //   {
            //    t.Persons.Find(e => e == person);
                person.Subjects.Find(e => e.NameSubject == subject.NameSubject).AddAssessment(assessment); 
        //    }
        }

        public void ShowSession(List<ISession> session)
        {
            foreach (ISession f in session)
            {
                f.ToString();
            }
        }

        public override string ToString() => $"{SessionType} session";
    }
}
