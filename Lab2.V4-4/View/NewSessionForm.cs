using System;
using System.Windows.Forms;
using Lab2;
using Lab4.Controllers;

namespace Lab4.View
{
    public partial class NewSessionForm : Form
    {
        private readonly NewSessionFormController _controller;

        public NewSessionForm(NewSessionFormController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void SessionTypeCheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                _controller.SessionType = GetSessionType(radioButton);
            }
        }

        private SessionType GetSessionType(RadioButton radioButton)
        {
            if (radioButton == winterRadioButton)
                return SessionType.Winter;
            else
                return SessionType.Summer;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Fill in all fields");
            }
        }
    }
}
