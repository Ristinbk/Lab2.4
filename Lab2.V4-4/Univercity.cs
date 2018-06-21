using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{

    public class Univercity
    {
        public string Name { get; set; }
        public List<IGroup> Groups { get; }
        public List<IPerson> Teachers { get; }
        public List<ISubject> Subjects { get; }
        public List<ISession> Sessions { get; }

        public Univercity(string name) : this(name, new List<IPerson>(), new List<ISubject>()) => Name = name;

        public Univercity(string name, List<IPerson> teacher, List<ISubject> subjects, params IGroup[] groups)
        {
            Teachers = new List<IPerson>();
            Subjects = new List<ISubject>();
            Groups = new List<IGroup>();
            Sessions = new List<ISession>();
            foreach (var d in groups)
            {
                if (!(Groups.Contains(d)))
                {
                    Groups.Add(d);
                }
            }
        }

        public void AddSession(ISession session)
        {
            if (session == null)
                throw new ArgumentNullException();
            Sessions.Add(session);
        }

        public void AddGroup(IGroup group)
        {
            if (group == null)
                throw new ArgumentNullException();
            if (!Groups.Contains(group))
            {
                Groups.Add(group);
            }
        }

        public void AddStudentInGroup(string numberGroup, IPerson student)
        {
            if (string.IsNullOrWhiteSpace(numberGroup))
                throw new ArgumentException();
            if (student == null)
                throw new ArgumentNullException();
            IGroup group = GetGroup(numberGroup);
            if (group == null)
                throw new ArgumentNullException();
            group?.AddPerson(student);
        }

        public void AddTeacher(IPerson teacher)
        {
            if (teacher == null)
                throw new ArgumentNullException();
            if (Teachers == null)
                throw new ArgumentNullException();
            Teachers.Add(teacher);
        }

        public void AddSubject(ISubject subject)
        {
            if (subject == null)
                throw new ArgumentNullException();
            if (Subjects == null)
                throw new ArgumentNullException();
            Subjects.Add(subject);
        }

        public void AddTeacherToSubject(IPerson teacher, ISubject subject)
        {
            if (teacher == null)
                throw new ArgumentNullException();
            if (subject == null)
                throw new ArgumentNullException();
            var a = Subjects.Find(e => e.NameSubject == subject.NameSubject);
            if (a != null)
            {
                a.AddTeacher(teacher);
                teacher.Subjects.Add(subject);
            }
        }

        public void RemovePerson(string numberGroup, string id)
        {
            if (string.IsNullOrWhiteSpace(numberGroup))
                throw new ArgumentException();
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException();
            IGroup dep = GetGroup(numberGroup);
            if (dep == null)
                throw new ArgumentNullException();
            dep.RemovePerson(id);
        }

        public void MovePerson(string fromDepId, string empId, string toDepId)
        {
            if (string.IsNullOrWhiteSpace(fromDepId))
                throw new ArgumentException();
            if (string.IsNullOrWhiteSpace(toDepId))
                throw new ArgumentException();
            if (string.IsNullOrWhiteSpace(empId))
                throw new ArgumentException();
            var fromDep = GetGroup(fromDepId);
            var toDep = GetGroup(toDepId);
            if (!(fromDep == null || toDep == null))
            {
                var e = fromDep.GetPerson(empId);
                if (e != null)
                {
                    fromDep.RemovePerson(empId);
                    toDep.AddPerson(e);
                }
            }
        }

        public IGroup GetGroup(string numberGroup)
        {
            if (string.IsNullOrWhiteSpace(numberGroup))
                throw new ArgumentException();
            return Groups.Find(e => e.NumberGroup.CodeSpecialty + e.NumberGroup.Number == numberGroup);
        }

        public override string ToString() => $"\"{Name}\"";
    }
}
