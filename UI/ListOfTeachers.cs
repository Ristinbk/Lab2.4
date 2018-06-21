using System;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class ListOfTeachers : Form
    {
        public ListOfTeachers()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void _homeButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }

        private void _lastNameTeacherTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void _createButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("№");
            dataTable.Columns.Add("ФИО");
            dataTable.Columns.Add("Пол");
            dataTable.Columns.Add("Предмет");

            DataRow row = dataTable.NewRow();
            row["№"] = 1;
            row["ФИО"] = _lastNameTeacherTextBox.Text + "  " + _firstNameTeacherTextBox.Text + "  " + _patromicTeacherTextBox.Text;
            row["Пол"] = _maleRadioButton.Text;
            row["Предмет"] = _subjectsComboBox.Text;


            dataTable.Rows.Add(row);
            foreach (DataRow Drow in dataTable.Rows)
            {
                int num = StudentGroupDataGridView.Rows.Add();
                StudentGroupDataGridView.Rows[num].Cells[0].Value = Drow["№"].ToString();
                StudentGroupDataGridView.Rows[num].Cells[1].Value = Drow["ФИО"].ToString();
                StudentGroupDataGridView.Rows[num].Cells[2].Value = Drow["Пол"].ToString();
                StudentGroupDataGridView.Rows[num].Cells[3].Value = Drow["Предмет"].ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
