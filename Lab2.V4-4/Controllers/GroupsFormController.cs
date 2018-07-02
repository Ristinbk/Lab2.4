using System.Collections.Generic;
using System.Linq;
using Lab2;

namespace Lab4.Controllers
{
    public class GroupsFormController
    {
        public Univercity Univercity { get; private set; }

        public List<IGroup> Groups =>Univercity?.Groups?? new List<IGroup>();
        public IGroup SelectedGroup { get; set; }        
        public List<IStudent> Students => SelectedGroup?.Students??new List<IStudent>();

        public bool CanAddGroup => Univercity != null;
        public bool CanAddStudent => SelectedGroup != null;

        public string CodeSpecilty => SelectedGroup.NumberGroup.CodeSpecialty;

        public GroupsFormController(Univercity U)
        {
            Univercity = U;
        }

        public void AddGroup(IGroup group)
        {
            Univercity.AddGroup(group);
        }

        public void AddStudent(IStudent student)
        {
            SelectedGroup.AddStudent(student);
        }
        
        public void SelectGroup(string numberGroup)
        {
            SelectedGroup = Groups.Find(d => d.NumberGroup.ToString().Equals(numberGroup));
        }

        public void RemoveGroup(string numberGroup)
        {
            Univercity.RemoveGroup(numberGroup);
        }

        public void RemoveStudent(string id)
        {
            SelectedGroup.RemoveStudent(id);
        }
    }
}
