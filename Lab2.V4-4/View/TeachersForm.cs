using Lab2;
using Lab4.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.View
{
    public partial class TeachersForm : Form
    {
        private readonly TeachersFormController _controller;
        public event EventHandler UpdateForm;

        public TeachersForm(TeachersFormController controller)
        {
            InitializeComponent();
            _controller = controller;
            ShowTeachers();
            ShowSubjects();
            UpdateForm += OnUpdateForm;
        }

        private void OnUpdateForm(object sender, EventArgs e)
        {
            ShowTeachers();
            ShowSubjects();
            EnableAddGroupButton();
        } 

        private void ShowTeachers()
        {
            teachersListView.Items.Clear();
            foreach (var t in _controller.Teachers)
            {
                ListViewItem teacher = new ListViewItem();
                teacher.SubItems.Add(t.Id.ToString());
                teacher.SubItems.Add(t.Name.ToString());
                teacher.SubItems.Add($"{t.DateBirthday:d}");
                teacher.SubItems.Add($"{t.Title}");
                teachersListView.Items.Add(teacher);
            }
        }

        private void ShowSubjects()
        {
            subjectsListView.Items.Clear();
            foreach (var t in _controller.Subjects)
            {
                ListViewItem subject = new ListViewItem();
                subject.SubItems.Add(t.NameSubject);
                subject.SubItems.Add(t.NameTeacher);
                subjectsListView.Items.Add(subject);
            }
        }

        private void EnableAddGroupButton()
        {
            newTeacherButton.Enabled = _controller.CanAddTeacher;
            newSubjectButton.Enabled = _controller.CanAddSubject;
        }

        private void teachersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teachersListView.SelectedItems.Count == 0)
                return;
            var item = teachersListView.SelectedItems[0];
            _controller.SelectTeacher(item.SubItems[1].Text);
            UpdateForm?.Invoke(this, e);  
        }

        private void backlButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void teachersListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = teachersListView.Columns[e.ColumnIndex].Width;
        }

        private void subjectsListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = subjectsListView.Columns[e.ColumnIndex].Width;
        }

        private void subjectsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void removeTeachertButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem t in teachersListView.CheckedItems)
                _controller.RemoveTeacher(t.SubItems[1].Text);
            UpdateForm?.Invoke(this, e);
        }

        private void newSubjectButton_Click(object sender, EventArgs e)
        {
            var newSubjectController = new NewSubjectFormController(_controller.SubjectType);
            var newSubjectForm = new NewSubjectForm(newSubjectController);
            if (newSubjectForm.ShowDialog() == DialogResult.OK)
            {
                ISubject newSubject = newSubjectController.Subject;
                _controller.AddSuject(newSubject);
            }
            ShowSubjects();
        }
    }
}
