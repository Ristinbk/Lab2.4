using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    public class Univercity
    {
        public string Name { get; set; }
        public List<IPerson> Entrants { get; }
        public List<ISubject> Subjects { get; }
        public List<IPerson> Teachers { get; }
        public List<IGroup> Groups { get; }
        public List<ISession> Sessions { get; }

        public Univercity(string name)
        {
            Name = name;
            Entrants = new List<IPerson>();
            Subjects = new List<ISubject>();
            Teachers = new List<IPerson>();
            Groups = new List<IGroup>();
            Sessions = new List<ISession>();
        }

        public void AddEntrant(IPerson entrant)
        {
            if (entrant == null)
                throw new ArgumentNullException();
            Entrants.Add(entrant);            
        }

        public void AddSubject(ISubject subject)
        {
            if (subject == null)
                throw new ArgumentNullException();
            if (!Subjects.Contains(subject))
            {
                Subjects.Add(subject);
            }
        }

        public void AddTeacher(IPerson teacher)
        {
            if (teacher == null)
                throw new ArgumentNullException();
            Teachers.Add(teacher);
        }

        public void AddGroup(IGroup group)
        {
            if (group == null)
                throw new ArgumentNullException();
            GetGroup(group.NumberGroup.ToString());
            Groups.Add(group);
            //if ()
            //{

            //}
            //else
            //{
            //    Console.WriteLine("Группа уже существует, создать вторую?");
            //    //    var s =  Console.ReadLine();
            //    group.NumberGroup =  new NumberGroup(group.NumberGroup);
            //        Groups.Add(group);
            //}

        }

        public void AddSession(ISession session)
        {
            if (session == null)
                throw new ArgumentNullException();
            Sessions.Add(session);
        }

        public void MoveEntrantInGroup(string numberGroup, string id)
        {
            if (numberGroup == null)
                throw new ArgumentException();
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            IPerson e = GetEntrant(id);
            IGroup g = GetGroup(numberGroup);
            g.AddPerson(new Student(e.Name, e.DateOfBirth, e.Gender, new Id(g.NumberGroup, e.Id))); 
            Entrants.Remove(e);
        }

        private IPerson GetEntrant(string id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            return Entrants.Find(t => t.Id.ToString().Equals(id));
        }

        public IPerson GetTeacher(string id)
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
            IPerson t = GetTeacher(id);
            ISubject s = GetSubject(nameSubject);
            if (s != null)
            {
                s.AddTeacher(t);
                t.AddSubject(s);
            }
        }

        public void MoveToAnotherGroup(string id, string fromNumberGroup, string toNumberGroup)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            if (fromNumberGroup == null)
                throw new ArgumentException();
            if (toNumberGroup == null)
                throw new ArgumentException();            
            var g = GetGroup(fromNumberGroup);
            GetGroup(toNumberGroup).AddPerson(g.GetPerson(id));
            g.RemovePerson(id);
        }

        public void RemoveEntrant(string id)
        {
            if (id == null)
                throw new ArgumentException();
            Entrants.Remove(Entrants.Find(e => e.Id.ToString().Equals(id)));
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

        public void RemovePersonInGroup(string id, string numberGroup)
        {
            if (id == null)
                throw new ArgumentException();
            if (numberGroup == null)
                throw new ArgumentNullException(nameof(numberGroup));
            GetGroup(numberGroup).RemovePerson(id);
        }

        public void RemoveSession(string session)
        {
            if (session == null)
                throw new ArgumentException();
            Sessions.Remove(GetSession(session));              
        }

        public void ShowEntrants()
        {
            foreach (IPerson f in Entrants)
                Console.WriteLine(f.ToString());
        }

        public void ShowTeachers()
        {
            foreach (IPerson f in Teachers)
                Console.WriteLine(f.ToString());
        }

        public void ShowSubjects()
        {
            foreach (ISubject f in Subjects)
                Console.WriteLine(f.ToString());
        }

        public void ShowGroup()
        {
            foreach (IGroup f in Groups)
                Console.WriteLine(f.ToString());
        }

        public void ShowPersonsInGroup(string  numberGroup)
        {
            if (numberGroup == null)
                throw new ArgumentNullException();
            GetGroup(numberGroup).ShowAllPersonInGroop();
        }

        public void ShowSession()
        {
            foreach (ISession f in Sessions)
                Console.WriteLine(f.ToString());
        }

        public void ShowResultOfSession(string session, string numberGroup, string nameSubject)
        {
            if (session == null)
                throw new ArgumentNullException(nameof(session));
            if (numberGroup == null)
                throw new ArgumentNullException(nameof(numberGroup));
            if (nameSubject == null)
                throw new ArgumentNullException(nameof(nameSubject));
            GetSession(session).ShowResultToGroup(GetGroup(numberGroup), GetSubject(nameSubject));
        }
        
        public void MoveResultSubject(string session, string numberGroup, string nameSubject, Assessment assessment)
        {
            var c = GetSession(session);
            var g = GetGroup(numberGroup);
            var s = GetSubject(nameSubject);

            foreach (var t in g.Persons)
            {
                c.MoveToSubjectAssessment(t, s, assessment);
            }
        }

        public void MoveResultPerson(string session, string numberGroup, string id, string nameSubject, Assessment assessment)
        {
            GetSession(session).MoveToSubjectAssessment(GetGroup(numberGroup).GetPerson(id), GetSubject(nameSubject), assessment);
        }

        public void ShowResultSubjectInGroup(string numberGroup, string nameSubject)
        {
      //      GetGroup(numberGroup).Persons.Where(s => s.Subjects.Find(e => e.NameSubject.Equals(nameSubject)).ToString());
        }

        public void ShowResultSessionForPerson(string numberGroup, string id)
        {
            GetGroup(numberGroup).GetPerson(id).ShowAllSubjects();
        }

        public void ShowListOfDebtors()
        {
        //    Groups.FindAll(p => p.Persons.Where(s => s.Subjects.Find(n => n.Assessment.Equals(Assessment.None))));

            //var r = from IGroup in Groups
            //        from IPerson in IGroup.Persons
            //        from ISubject in IPerson.Subjects
            //        where ISubject.Assessment.Equals(Assessment.None) && ISubject.Assessment.Equals(Assessment.NoCredited)
            //        //    where IPerson.Subjects
            //        select IGroup;
            ////        r.

            foreach (var t in Groups)
            {
                t.Persons.Where(e => e.Subjects.TrueForAll(d =>
                d.Assessment.Equals(Assessment.None) && d.Assessment.Equals(Assessment.NoCredited))).ToString();
            }


        }

        public override string ToString() => $"\"{Name}\"";
    }
}
