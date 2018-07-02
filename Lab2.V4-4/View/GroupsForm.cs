using System;
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
            ShowGroups();
            ShowStudents();
            UpdateForm += OnUpdateForm;
        }

        private void OnUpdateForm(object sender, EventArgs e)
        {
            ShowGroups();
            ShowStudents();
            EnableAddGroupButton();
        }

        private void ShowGroups()
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
                studentsListView.Items.Add(student);
            }
        }

        private void EnableAddGroupButton()
        {
            newGroupButton.Enabled = _controller.CanAddGroup;
            newStudentButton.Enabled = _controller.CanAddStudent;
        }

        private void studentListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = studentsListView.Columns[e.ColumnIndex].Width;
        }

        private void newStudentButton_Click(object sender, EventArgs e)
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

        private void newGroupButton_Click(object sender, EventArgs e)
        {
            var newGroupController = new NewGroupFormController(_controller.CodeSpecilty);
            var newGroupForm = new NewGroupForm(newGroupController);
            if (newGroupForm.ShowDialog() == DialogResult.OK)
            {
                IGroup newGroup = newGroupController.Group;
                _controller.AddGroup(newGroup);
            }
            ShowGroups();
        }

        private void removeGroupButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem t in groupListView.CheckedItems)
                _controller.RemoveGroup(t.SubItems[1].Text);
            UpdateForm?.Invoke(this, e);
        }

        private void groupListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = groupListView.Columns[e.ColumnIndex].Width;
        }

        private void groupListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupListView.SelectedItems.Count == 0)
                return;
            var item = groupListView.SelectedItems[0];
            _controller.SelectGroup(item.SubItems[1].Text);
            UpdateForm?.Invoke(this, e);
        }

        private void studentsListView_SelectedIndexChanged(object sender, EventArgs e)
        {        }


        private void removeStudentButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem t in studentsListView.CheckedItems)
                _controller.RemoveStudent(t.SubItems[1].Text);
            UpdateForm?.Invoke(this, e);
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
