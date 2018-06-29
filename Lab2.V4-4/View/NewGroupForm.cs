using System;
using System.ComponentModel;
using System.Windows.Forms;
using Lab4.Controllers;
using Lab2;

namespace Lab4.View
{
    public partial class NewGroupForm : Form
    {
        private readonly NewGroupFormController _controller;

        public NewGroupForm(NewGroupFormController controller)
        {
            InitializeComponent();
            _controller = controller;

            GetGroups();
            codeSpecialtyComboBox.Text = _controller.CodeSpecialty.ToString();

            _controller.PropertyChanged += _controller_PropertyChanged;
        }

        private void _controller_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_controller.GetCanSave))
                addButton.Enabled = _controller.GetCanSave();
        }

        public void GetGroups()
        {
            foreach (var t in _controller.Groups)
                codeSpecialtyComboBox.Items.Add(t);
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void depTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void phoneNumberTextBox_Validating(object sender, CancelEventArgs e)
        //{
        //    if (!int.TryParse(phoneNumberTextBox.Text, out _))
        //    {
        //        _controller.NumberGroup = null;
        //        e.Cancel = true;
        //        errorProvider1.SetError(phoneNumberTextBox, "Invalid phone number");
        //    }
        //}

        //private void phoneNumberTextBox_Validated(object sender, EventArgs e)
        //{
        //    errorProvider1.SetError(phoneNumberTextBox, "");
        //    _controller.NumberGroup = int.Parse(phoneNumberTextBox.Text);
        //}



        //private void numberTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    _controller.Number = Int32.Parse(numberTextBox.Text);
        //}

        //private void codeSpecialtyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    _controller.CodeSpecialty = codeSpecialtyComboBox.SelectedItem as Specialty?;
        //}


        // TODO: чтоб валидация срабатывала сразу, то приходится писать вот такую хрень, что достаточно стрёмно
        // Всё больше склоняюсь к использованию DevExpress или забить на это :)
        //private void phoneNumberTextBox_TextChanged(object sender, EventArgs e) 
        //{
        //    var cancelEventArgs = new CancelEventArgs();
        //    phoneNumberTextBox_Validating(this, cancelEventArgs);
        //    if (!cancelEventArgs.Cancel)
        //        phoneNumberTextBox_Validated(this, null);
        //}
    }
}
