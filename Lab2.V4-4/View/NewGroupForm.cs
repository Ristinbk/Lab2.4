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

            GetSpecialties();
            codeSpecialtyComboBox.Text = _controller.CodeSpecialty.ToString();
           _controller.PropertyChanged += _controller_PropertyChanged;
        }

        private void _controller_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_controller.CanSave))
                addButton.Enabled = _controller.CanSave;
        }

        public void GetSpecialties()
        {
            foreach (var t in _controller.Specialties)
                codeSpecialtyComboBox.Items.Add(t);
        }


        private void codeSpecialtyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.CodeSpecialty = codeSpecialtyComboBox.SelectedItem as Specialty?;
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
