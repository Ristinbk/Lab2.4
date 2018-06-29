using System.Collections.Generic;
using System.Linq;
using Lab2;

namespace Lab4.Controllers
{
    public class GroupsFormController
    {
        private Univercity _univercity;

        public List<IGroup> Groups =>_univercity?.Groups?? new List<IGroup>();
        public IGroup SelectedUnivercity { get; set; }
        public IGroup SelectedGroup { get; set; }
        public List<IStudent> Students => SelectedGroup?.Students??new List<IStudent>();
        public string OrgInfo => IsSet ? $"{ _univercity }" : " ";

        public bool CanAddGroup => SelectedUnivercity != null;
        public bool CanAddStudent => SelectedGroup != null;
        private bool IsSet => _univercity != null;

        public GroupsFormController(Univercity U)
        {
           _univercity = U;
        }

        public void InitializeUnivercity()
        {
            var univercity = new Univercity("test");
            Demo.InitializeUnivercity(univercity);
            _univercity = univercity;
        }

        public void AddStudent(IStudent student)
        {
            SelectedGroup.AddStudent(student);
        }

        public void AddGroup(IGroup group)
        {
            _univercity.AddGroup(group);
        }

        public void SelectGroup(string numberGroup)
        {
            SelectedGroup = Groups.Find(d => d.NumberGroup.ToString().Equals(numberGroup));
        }

        public void RemoveGroup(string numberGroup)
        {
            _univercity.RemoveGroup(numberGroup);
        }

        public void RemoveStudent(string id)
        {
            SelectedGroup.RemoveStudent(id);
        }
    }
}
