using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Lab4.Controllers;

namespace Lab4.View
{
    public partial class NewStudentForm : Form
    {
        private readonly NewStudentFormController _controller;

        public NewStudentForm(NewStudentFormController controller)
        {
            InitializeComponent();
            _controller = controller;

            yearComboBox.Items.AddRange(Enumerable.Range(1950, 50).Cast<object>().ToArray());
            monthComboBox.Items.AddRange(Enumerable.Range(1, 12).Cast<object>().ToArray());
            dayComboBox.Items.AddRange(Enumerable.Range(1, 30).Cast<object>().ToArray());
            _controller.PropertyChanged += _controller_PropertyChanged;
        }

        private void _controller_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_controller.CanSave))
                addButton.Enabled = _controller.CanSave;
        }
       
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void firstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateString(firstNameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(firstNameTextBox, "Invalid name");
            }
        }

        private void lastNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateString(lastNameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(lastNameTextBox, "Invalid name");
            }
        }

        private void patronomycTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateString(patronomycTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(patronomycTextBox, "Invalid name");
            }
        }

        static bool ValidateString(string input)
        {
            return Regex.IsMatch(input, @"^\w+$");
        }

        private void firstNameTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(firstNameTextBox, "");
            _controller.FirstName = firstNameTextBox.Text;
        }

        private void lastNameTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(lastNameTextBox, "");
            _controller.LastName = lastNameTextBox.Text;
        }

        private void patronomycTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(patronomycTextBox, "");
            _controller.Patronomyc = patronomycTextBox.Text;
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.Year = yearComboBox.SelectedItem as int?;
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.Month = monthComboBox.SelectedItem as int?;
        }

        private void dayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.Day = dayComboBox.SelectedItem as int?;
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