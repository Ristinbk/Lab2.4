using Lab4.View;
using System;
using System.Windows.Forms;
using Lab4.Controllers;

namespace Lab4.View
{
    public partial class UnivercityForm : Form
    {
        private readonly UnivercityFormController _controller;

        public UnivercityForm(UnivercityFormController controller)
        {
            InitializeComponent();
            _controller = controller;
        }    

        private void openSessionFormButton_Click(object sender, EventArgs e)
        {
            SessionsFormController controller = new SessionsFormController(_controller.Univercity);
            var sessionpForm = new SessionForm(controller);
            if (sessionpForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new SessionForm(controller));
            }
        }

        private void openGroupFormButton_Click(object sender, EventArgs e)
        {
            GroupsFormController controller = new GroupsFormController(_controller.Univercity);
            var groupsForm = new GroupsForm(controller);
            if (groupsForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new GroupsForm(controller));
            }
        }

        private void openTeacherFormButton_Click(object sender, EventArgs e)
        {
           TeachersFormController controller = new TeachersFormController(_controller.Univercity);
            var taechersForm = new TeachersForm(controller);
            if (taechersForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new TeachersForm(controller));
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
