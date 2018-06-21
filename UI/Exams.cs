using System;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class Exams : Form
    {
        public Exams()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Exams_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _createSubjectbutton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Предмет");
            dataTable.Columns.Add("Преподаватель");
            dataTable.Columns.Add("Тип");

            DataRow row = dataTable.NewRow();
            row["Предмет"] = 1;
            row["Преподаватель"] =  _nameTeacherComboBox.Text;
            row["Тип"] = _creditRadioButton.Text;


            dataTable.Rows.Add(row);
            foreach (DataRow Drow in dataTable.Rows)
            {
                int num = StudentGroupDataGridView.Rows.Add();
                StudentGroupDataGridView.Rows[num].Cells[0].Value = Drow["Предмет"].ToString();
                StudentGroupDataGridView.Rows[num].Cells[1].Value = Drow["Преподаватель"].ToString();
                StudentGroupDataGridView.Rows[num].Cells[2].Value = Drow["Тип"].ToString();
            }
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
