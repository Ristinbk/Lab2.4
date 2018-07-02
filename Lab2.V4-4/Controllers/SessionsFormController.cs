using Lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lab4.Controllers
{
    public class SessionsFormController
    {
        private Univercity Univercity { get; set; }

        public List<ISession> Sessions => Univercity?.Sessions ?? new List<ISession>();
        public List<IGroup> Groups => Univercity?.Groups ?? new List<IGroup>();
    
        public ISession SelectedSession { get; set; }
        public IGroup SelectedGroup { get; set; }
        public ISubject SelectedSubject { get; set; }
        public string Specialty => SelectedGroup.NumberGroup.CodeSpecialty;
        public string SubjectType => SelectedSubject.SubjectType.ToString();

        public List<ISubject> Subjects => SelectedSession?.Subjects ?? new List<ISubject>();
        public List<IStudent> Students => SelectedGroup?.Students ?? new List<IStudent>();

        public bool CanAddGroup => Univercity != null;
        public bool CanAddSession => Univercity != null;
        public bool CanAddSubject => SelectedSession != null;

        public string Result => CodeSpecilty;

        public string CodeSpecilty => SelectedGroup.NumberGroup.CodeSpecialty;

        public SessionsFormController(Univercity U)
        {
            Univercity = U;
        }

        public void SelectSession(string session)
        {
            SelectedSession = Sessions.Find(d => d.ToString().Equals(session));
        }

        public void SelectGroup(string numberGroup)
        {
            SelectedGroup = Groups.Find(d => d.NumberGroup.ToString().Equals(numberGroup));
        }

        public ISubject SelectSubject(string subject)
        {
            return SelectedSubject = Subjects.Find(s => s.NameSubject.ToString().Equals(subject));
        }

        public void AddSession(ISession session)
        {
            Univercity.AddSession(session);
        }

        public void AddSubject(ISubject subject)
        {
            Univercity.AddSubject(subject);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        internal void RemoveSubject(string subject)
        {
           Univercity.RemoveSubject(subject);
        }

        public void RemoveSession(string session)
        {
            Univercity.RemoveSession(session);
        }
    }
}
