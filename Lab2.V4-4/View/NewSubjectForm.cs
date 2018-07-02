using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Lab2;
using Lab4.Controllers;

namespace Lab4.View
{
    public partial class NewSubjectForm : Form
    {
        private readonly NewSubjectFormController _controller;

        public NewSubjectForm(NewSubjectFormController controller)
        {
            InitializeComponent();
            _controller = controller;
            _controller.PropertyChanged += _controller_PropertyChanged;
        }

        private void _controller_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_controller.CanSave))
                addButton.Enabled = _controller.CanSave;
        }

        private void subjectNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateString(subjectNameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(subjectNameTextBox, "Invalid name");
            }
        }

        static bool ValidateString(string input)
        {
            return Regex.IsMatch(input, @"^\w+$");
        }

        private void subjectNameTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(subjectNameTextBox, "");
            _controller.SubjectName = subjectNameTextBox.Text;
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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

        private void SessionTypeCheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                _controller.SubjectType = GetSubjectType(radioButton);
            }
        }

        private SubjectType GetSubjectType(RadioButton radioButton)
        {
            if (radioButton == creditedRadioButton)
                return SubjectType.Credited;
            else
                return SubjectType.Exem;
        }
    }
}

