using System;
using System.Windows.Forms;
//using Model;

namespace UI
{
    public partial class MainForm : Form
    {  
        public MainForm()
        {
            InitializeComponent();
        }

        private void _createEnrolleeButton_Click(object sender, EventArgs e)
        {
            Hide();
            Enrollee enrollee = new Enrollee();
            //        Enrollee enrollee = new Enrollee(new FileRepository<DataTable>("test.xml", DataTable.GetDataTableSchema()));
            enrollee.ShowDialog();
            Close();
        }

        private void listOfTeachersButton_Click(object sender, EventArgs e)
        {
            Hide();
            ListOfTeachers listOfTeachers = new ListOfTeachers();
            listOfTeachers.ShowDialog();
            Close();
        }

        private void _listOfStudentGroupsButton_Click(object sender, EventArgs e)
        {
            Hide();
            ListOfStudentGroups listOfStudentGroups = new ListOfStudentGroups();
            listOfStudentGroups.ShowDialog();
            Close();
            
        }

        private void _listOfSubjectsButton_Click(object sender, EventArgs e)
        {
            Hide();
            Exams exams = new Exams();
            exams.ShowDialog();
            Close();
        }

        private void _listOfSessionsButton_Click(object sender, EventArgs e)
        {
            Hide();
                Form1 session = new Form1();
          //  Form2 session = new Form2();
            //   Session session = new Session();
            session.ShowDialog();
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
