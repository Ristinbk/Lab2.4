using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    public class Univercity
    {
        public string Name { get; set; }
        public List<IStudent> Students { get; }
        public List<ISubject> Subjects { get; }
        public List<ITeacher> Teachers { get; }
        public List<IGroup> Groups { get; }
        public List<ISession> Sessions { get; }

        public Univercity(string name)
        {
            Name = name;
            Students = new List<IStudent>();
            Subjects = new List<ISubject>();
            Teachers = new List<ITeacher>();
            Groups = new List<IGroup>();
            Sessions = new List<ISession>();
        }

        public void AddStudent(IStudent student)
        {
            if (student == null)
                throw new ArgumentNullException();
            Students.Add(student);
        }

        public void AddSubject(ISubject subject)
        {
            if (subject == null)
                throw new ArgumentNullException();
            if (!Subjects.Contains(subject))
                Subjects.Add(subject);
        }

        public void AddTeacher(ITeacher teacher)
        {
            if (teacher == null)
                throw new ArgumentNullException();
            Teachers.Add(teacher);
        }

        public void AddGroup(IGroup group)
        {
            if (group == null)
                throw new ArgumentNullException();
            if (!Groups.Contains(group))
                Groups.Add(group);
            else
            {
                int a = Groups.FindAll(s => s
                  .NumberGroup.ToString().Substring(0,5)
                    .Equals(group.NumberGroup.ToString().Substring(0, 5)))
                    .Count();
                group.NumberGroup= new NumberGroup(group.NumberGroup, ++a);
                Groups.Add(group);
            }
        }

        public void AddSession(ISession session)
        {
            if (session == null)
                throw new ArgumentNullException();
            if (!Sessions.Contains(session))
                Sessions.Add(session);
        }

        public void MoveStudentInGroup(string numberGroup, string id)
        {
            if (numberGroup == null)
                throw new ArgumentException();
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            IStudent e = GetStudent(id);
            IGroup g = GetGroup(numberGroup);
            g.AddStudent(new Student(e.Name, e.DateBirthday, e.Id));
            Students.Remove(e);
        }

        public void MoveStudentToAnotherGroup(string id, string toNumberGroup)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            if (toNumberGroup == null)
                throw new ArgumentException();
            IGroup g1 = GetGroup(id.Substring(0, 5));
            IGroup g2 = GetGroup(toNumberGroup);
            var s = g1.GetStudent(id);
            g2.AddStudent(s);
            g1.RemoveStudent(id);
        }

        public IStudent GetStudent(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            return Students.Find(t => t.Id.ToString().Equals(id));
        }

        public ITeacher GetTeacher(string id)
        {
            return Teachers.Find(e => e.Id.ToString().Equals(id));
        }

        public ISubject GetSubject(string nameSubject)
        {
            return Subjects.Find(e => e.NameSubject.Equals(nameSubject));
        }

        public IGroup GetGroup(string numberGroup)
        {
            if (numberGroup == null)
                throw new ArgumentException();
            return Groups.Find(g => g.NumberGroup.ToString().Equals(numberGroup));
        }

        public ISession GetSession(string session)
        {
            return Sessions.Find(s => s.ToString().Equals(session));
        }

        public void AddSubjectToTeacher(string id, string nameSubject)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            if (nameSubject == null)
                throw new ArgumentNullException(nameof(nameSubject));
            ITeacher t = GetTeacher(id);
            ISubject s = GetSubject(nameSubject);
            if (s != null)
            {
                s.AddTeacher(t);
                t.AddSubject(s);
            }
        }

        public void RemoveStudent(string id)
        {
            if (id == null)
                throw new ArgumentException();
            Students.Remove(GetStudent(id));
        }

        public void RemoveTeacher(string id)
        {
            if (id == null)
                throw new ArgumentException();
            Teachers.Remove(GetTeacher(id));
        }

        public void RemoveSubject(string nameSubject)
        {
            if (nameSubject == null)
                throw new ArgumentException();
            Subjects.Remove(GetSubject(nameSubject));
        }

        public void RemoveGroup(string numberGroup)
        {
            if (numberGroup == null)
                throw new ArgumentNullException(nameof(numberGroup));
            Groups.Remove(GetGroup(numberGroup));
        }

        public void RemoveStudentInGroup(string id, string numberGroup)
        {
            if (id == null)
                throw new ArgumentException();
            if (numberGroup == null)
                throw new ArgumentNullException(nameof(numberGroup));
            GetGroup(numberGroup).RemoveStudent(id);
        }

        public void RemoveSession(string session)
        {
            if (session == null)
                throw new ArgumentException();
            Sessions.Remove(GetSession(session));
        }

        public void MoveResultPerson(string session, string numberGroup, string id, string nameSubject, Assessment assessment)
        {
            GetSession(session).MoveToSubjectAssessment(GetGroup(numberGroup).GetStudent(id), GetSubject(nameSubject), assessment);
        }

        public override string ToString() => $"\"{Name}\"";
    }
}
