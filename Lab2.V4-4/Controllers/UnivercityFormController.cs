using System.Collections.Generic;
using System.Linq;
using Lab2;

namespace Lab4.Controllers
{
    public class UnivercityFormController
    {
        public Univercity Univercity { get; private set; }

        public List<IGroup> Groups => Univercity?.Groups ?? new List<IGroup>();
        public IGroup SelectedGroup { get; set; }
        public List<IStudent> Students => SelectedGroup?.Students ?? new List<IStudent>();

        public bool CanAddGroup => Univercity != null;
        public bool CanAddStudent => SelectedGroup != null;

        public string CodeSpecilty => SelectedGroup.NumberGroup.CodeSpecialty;

        public UnivercityFormController(Univercity U)
        {
            Univercity = U;
        }

        public void InitializeUnivercity()
        {
            var univercity = new Univercity("test");
            Demo.InitializeUnivercity(univercity);
            Univercity = univercity;
        }

    }
}