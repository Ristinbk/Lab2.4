using System;
using System.Windows.Forms;

namespace UI
{
    public partial class StudentGroup : Form
    {
        public StudentGroup()
        {
            InitializeComponent();
        }

        private void _homeButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }
    }
}
