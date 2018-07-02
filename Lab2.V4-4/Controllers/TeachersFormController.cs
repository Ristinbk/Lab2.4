using System;
using System.Collections.Generic;
using Lab2;

namespace Lab4.Controllers
{
    public class TeachersFormController
    {
        public Univercity Univercity { get; private set; }


        public ISubject SelectedSubject { get; set; }
        public List<ITeacher> Teachers => Univercity?.Teachers ?? new List<ITeacher>();
        public ITeacher SelectedTeacher { get; set; }
        public List<ISubject> Subjects => Univercity?.Subjects ?? new List<ISubject>();


        public string SubjectType => SelectedSubject.SubjectType.ToString();
        public bool CanAddTeacher => Univercity != null;
        public bool CanAddSubject => SelectedTeacher != null;

        public TeachersFormController(Univercity U)
        {
            Univercity = U;
        }
    
        public void SelectTeacher(string teacher)
        {
            Subjects.Find(d => d.NameTeacher.ToString().Equals(teacher));
        }

        public void AddTeacher(ITeacher teacher)
        {
            Univercity.AddTeacher(teacher);
        }

        public void AddSuject(ISubject subject)
        {
            SelectedTeacher.AddSubject(subject);
        }

        public void RemoveTeacher(string id)
        {
            Univercity.RemoveTeacher(id);
        }
    }
}
