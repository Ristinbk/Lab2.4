using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ListOfStudentGroups : Form
    {
        public ListOfStudentGroups()
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

        private void _createGroupButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Группа");

            DataRow row = dataTable.NewRow();
            row["Группа"] = _numberGroupTextBox.Text;
                
            dataTable.Rows.Add(row);
            foreach (DataRow Drow in dataTable.Rows)
            {
                int num = ListOfStudentGroupsDataGridView.Rows.Add();
                ListOfStudentGroupsDataGridView.Rows[num].Cells[0].Value = Drow["Группа"].ToString();

            }
        }

        private void _numberGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void _numberGroupTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
