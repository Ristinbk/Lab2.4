using System;
using System.Windows.Forms;
using Lab2;
using Lab4.View;
using Lab4.Controllers;

namespace Lab4.View
{
    public partial class SessionForm : Form
    {
        private readonly SessionsFormController _controller;
        public event EventHandler UpdateForm;

        public SessionForm(SessionsFormController controller)
        {
            InitializeComponent(); 
            _controller = controller;   
            ShowSessions();
            ShowGroups();
            ShowSubjects();
            UpdateForm += OnUpdateForm;
        }

        private void OnUpdateForm(object sender, EventArgs e)
        {
            ShowSessions();
            ShowGroups();
            ShowSubjects();
            EnableAddGroupButton();
        }

        private void EnableAddGroupButton()
        {
            newSessionButton.Enabled = _controller.CanAddSession;
            newSubjectButton.Enabled = _controller.CanAddSubject;
        }
        
        private void ShowSessions()
        {
            sessionsListView.Items.Clear();
            foreach (var t in _controller.Sessions)
            {
                ListViewItem session = new ListViewItem();
                session.SubItems.Add(t.ToString());
                sessionsListView.Items.Add(session);
            }
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

        private void ShowSubjects()
        {
            subjectsListView.Items.Clear();
            foreach (var t in _controller.Subjects)
            {
                ListViewItem subject = new ListViewItem();
                subject.SubItems.Add(t.ToString());
                subjectsListView.Items.Add(subject);
            }
        }

        private void ShowStudents(string subject)
        {
            studentsListView.Items.Clear();
            foreach (var t in _controller.Students)
            {
                ListViewItem student = new ListViewItem();
                student.SubItems.Add(t.Id.ToString());
                student.SubItems.Add(t.Name.ToString());
                student.SubItems.Add(t.Subjects.Find(s => s.NameSubject.Equals(subject)).Assessment.ToString());
                studentsListView.Items.Add(student);
            }
        } 

        private void groupListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupListView.SelectedItems.Count == 0)
                return;
            var item = groupListView.SelectedItems[0];
            _controller.SelectGroup(item.SubItems[1].Text);
            UpdateForm?.Invoke(this, e);
        }

        private void sessionsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sessionsListView.SelectedItems.Count == 0)
                return;
            var item = sessionsListView.SelectedItems[0];
            _controller.SelectSession(item.SubItems[1].Text);
            UpdateForm?.Invoke(this, e);
        }

        private void subjectsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subjectsListView.SelectedItems.Count == 0)
                return;
            var item = subjectsListView.SelectedItems[0];
           var s = _controller.SelectSubject(item.SubItems[1].Text);
            ShowStudents(s.NameSubject);
            UpdateForm?.Invoke(this, e);           
        }

        private void studentsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentsListView.SelectedItems.Count == 0)
                return;
            var item = studentsListView.SelectedItems[0];
            _controller.SelectGroup(item.SubItems[1].Text);
            UpdateForm?.Invoke(this, e);
        }

        private void newSessionButton_Click(object sender, EventArgs e)
        {
            if (_controller.SelectedSession == null) return;
            var newSessionController = new NewSessionFormController();
            var newSessionForm = new NewSessionForm(newSessionController);
            if (newSessionForm.ShowDialog() == DialogResult.OK)
            {
                ISession newSession = newSessionController.Session;
                _controller.AddSession(newSession);
            }
            ShowSessions();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void removeSessionButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem t in sessionsListView.CheckedItems)
                _controller.RemoveSession(t.SubItems[1].Text);
            UpdateForm?.Invoke(this, e);
        }

        private void newSubjectBbutton_Click(object sender, EventArgs e)
        {
            if (_controller.SelectedSubject == null) return;
            var newSubjectController = new NewSubjectFormController(_controller.SubjectType);
            var newSubjectForm = new NewSubjectForm(newSubjectController);
            if (newSubjectForm.ShowDialog() == DialogResult.OK)
            {
                ISubject newSubject = newSubjectController.Subject;
                _controller.AddSubject(newSubject);
            }
            ShowSessions();
        }

        private void removeSubjecttButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem t in subjectsListView.CheckedItems)
                _controller.RemoveSubject(t.SubItems[1].Text);
            UpdateForm?.Invoke(this, e);
        }
    }
}
