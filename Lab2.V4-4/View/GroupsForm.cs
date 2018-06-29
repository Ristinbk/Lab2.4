using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2;
using Lab4.Controllers;

namespace Lab4.View
{
    public partial class GroupsForm : Form
    {
        private readonly GroupsFormController _controller;
        public event EventHandler UpdateForm;

        public GroupsForm(GroupsFormController controller)
        {
            InitializeComponent();
            _controller = controller;
            UpdateForm += OnUpdateForm;
        }

        private void OnUpdateForm(object sender, EventArgs e)
        {
            UnivercityInfoTextBox.Text = _controller.OrgInfo;
            ShowaGroups();
            ShowStudents();
            EnableAddGroupButton();
        }

        private void ShowaGroups()
        {
            groupListView.Items.Clear();
            foreach (var t in _controller.Groups)
            {
                ListViewItem group = new ListViewItem();
                group.SubItems.Add(t.NumberGroup.ToString());
                groupListView.Items.Add(group);
            }
        }

        private void ShowStudents()
        {
            studentsListView.Items.Clear();
            foreach (var t in _controller.Students)
            {
                ListViewItem student = new ListViewItem();
                student.SubItems.Add(t.Id.ToString());
                student.SubItems.Add(t.Name.ToString());
                student.SubItems.Add($"{t.DateBirthday:d}");
                student.SubItems.Add(t.NumberGroup);
                studentsListView.Items.Add(student);
            }
        }

        private void EnableAddGroupButton()
        {
            addGroupButton.Enabled = _controller.CanAddGroup;
            newStudentButton.Enabled = _controller.CanAddStudent;
        }

        private void studentListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = studentsListView.Columns[e.ColumnIndex].Width;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newStudentButton_Click_1(object sender, EventArgs e)
        {
            if (_controller.SelectedGroup == null) return;

            var newStudentController = new NewStudentFormController();
            var newStudentForm = new NewStudentForm(newStudentController);

            if (newStudentForm.ShowDialog() == DialogResult.OK)
            {
                IStudent newStudent = newStudentController.Student;
                _controller.AddStudent(newStudent);
            }
            ShowStudents();
        }

        private void addGroupButton_Click(object sender, EventArgs e)
        {
            var newGroupController = new NewGroupFormController(_controller.Groups);
            var newGroupForm = new NewGroupForm(newGroupController);
            if (newGroupForm.ShowDialog() == DialogResult.OK)
            {
                IGroup newGroup = newGroupController.Group;
                _controller.AddGroup(newGroup);
            }
            UpdateForm?.Invoke(this, e);
        }

        private void removeGroupButton_Click(object sender, EventArgs e)
        {

        }

        private void groupListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (groupListView.SelectedItems.Count == 0)
                return;
            var item = groupListView.SelectedItems[0];
            _controller.SelectGroup(item.SubItems[1].Text);
            UpdateForm?.Invoke(this, e);
        }

        private void studentsListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (studentsListView.SelectedItems.Count == 0)
                return;
            var item = studentsListView.SelectedItems[0];
            _controller.SelectGroup(item.SubItems[1].Text);
            UpdateForm?.Invoke(this, e);
        }

        private void initButton_Click(object sender, EventArgs e)
        {
            _controller.InitializeUnivercity();
            UpdateForm?.Invoke(this, e);
        }
    }

}
