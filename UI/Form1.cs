using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        string path;
        DataTable dataTable;
        DataSet dataSet;

        public Form1()
        {
            path = "test2.xml";
            InitializeComponent();
            ButtonLoad();
        }

        private void _createButton_Click(object sender, EventArgs e)
        {
            ButtonSave_Click();
        }

        private void ButtonSave_Click()
        {
            //    if (dataSet != null)  
            dataTable = new DataTable();
            dataTable.Columns.Add("№").ColumnMapping = MappingType.Attribute;
            dataTable.Columns.Add("ФИО").ColumnMapping = MappingType.Attribute;
            dataTable.Columns.Add("Пол").ColumnMapping = MappingType.Attribute;
            dataTable.Columns.Add("Группа").ColumnMapping = MappingType.Attribute;

            DataRow row = dataTable.NewRow();
            row["ФИО"] = _lastNameStudentTextBox.Text + "  " + _firstNameStudentTextBox.Text + "  " + _patromicStudentTextBox.Text;
            row["Пол"] = _maleRadioButton.Text;
            row["Группа"] = _studentGroupComboBox.Text;
            dataTable.Rows.Add(row);
            dataSet.Tables.Add(dataTable);
            dataSet.WriteXml(path);
            var num = StudentGroupDataGridView.Rows;
            while (num.Count != 0)
            {
                num.Remove(num[num.Count - 1]);
            }
            ButtonLoad();
        }

        private void ButtonLoad()
        {
            dataSet = new DataSet("Root");
            if (File.Exists(path))
            {
                dataSet.ReadXml(path, XmlReadMode.InferSchema);
                for (int i = 0; i < dataSet.Tables.Count; i++)
                {
                    dataTable = dataSet.Tables[i];
                    foreach (DataRow Drow in dataTable.Rows)
                    {
                        int num = StudentGroupDataGridView.Rows.Add();
                        //   StudentGroupDataGridView.Rows[num].Cells[0].Value = Drow["№"].ToString();
                        StudentGroupDataGridView.Rows[num].Cells[0].Value = i+1;
                        StudentGroupDataGridView.Rows[num].Cells[1].Value = Drow["ФИО"].ToString();
                        StudentGroupDataGridView.Rows[num].Cells[2].Value = Drow["Пол"].ToString();
                        StudentGroupDataGridView.Rows[num].Cells[3].Value = Drow["Группа"].ToString();
                    }
                }
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{            
        //    //dataSet = new DataSet("Абитуриенты");
        //    //if (File.Exists(path))
        //    //{
        //    //    dataSet.ReadXml(path, XmlReadMode.InferSchema);
        //    //    dataTable = dataSet.Tables[0];
        //    //}
        //    //else
        //    //{
        //    //DataRow row = dataTable.NewRow();
        //    //row["№"] = 1;// (dataTable.Rows.Count+1).ToString();
        //    //row["ФИО"] = _lastNameStudentTextBox.Text + "  " + _firstNameStudentTextBox.Text + "  " + _patromicStudentTextBox.Text;
        //    //row["Пол"] = _maleRadioButton.Text;
        //    //row["Группа"] = _studentGroupComboBox.Text;
        //    //dataTable.Rows.Add(row);
        //    //foreach (DataRow Drow in dataTable.Rows)
        //    //{
        //    //    int num = StudentGroupDataGridView.Rows.Add();
        //    //    StudentGroupDataGridView.Rows[num].Cells[0].Value = Drow["№"].ToString();
        //    //    StudentGroupDataGridView.Rows[num].Cells[1].Value = Drow["ФИО"].ToString();
        //    //    StudentGroupDataGridView.Rows[num].Cells[2].Value = Drow["Пол"].ToString();
        //    //    StudentGroupDataGridView.Rows[num].Cells[3].Value = Drow["Группа"].ToString();
        //    //}
        //    //       dataSet.Tables.Add(dataTable);                
        //    //      }
        //    //    StudentGroupDataGridView.DataSource = dataTable;
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudenGroup_Load(object sender, EventArgs e)
        {

        }

        private void _homeButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }

        private void _nextButton_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
