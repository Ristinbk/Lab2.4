using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
//using Model;

namespace UI
{
    public partial class Enrollee : Form
    {
        //dataset dataset;
        //string path;
        //private readonly irepository<datatable> _datatables;

        public Enrollee()
        {
            //    path = "test.xml";
            InitializeComponent();
        }

        // public Enrollee(IRepository<DataTable> dt)
        // {
        ////    path = "test.xml";
        //     _dataTables = dt;
        //     InitializeComponent();
        //     _dataTables.DataSetChanged += _favorites_CollectionChanged;
        // //    FillFavoriteNumbers();
        // }

        // private void _favorites_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        // {
        //     FillFavoriteNumbers();
        // }

        // private void FillFavoriteNumbers()
        // {
        //     dataTable.WriteXml("test.xml");
        // }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataSet = new DataSet("Абитуриенты");
            //if (File.Exists(path))
            //{
            //    dataSet.ReadXml(path, XmlReadMode.InferSchema);
            //    dataTable = dataSet.Tables[0];
            //}
            //else
            //{
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("№");//.ColumnMapping = MappingType.Attribute;
            dataTable.Columns.Add("ФИО");//.ColumnMapping = MappingType.Attribute;
            dataTable.Columns.Add("Пол");//.ColumnMapping = MappingType.Attribute;
            dataTable.Columns.Add("Группа");//.ColumnMapping = MappingType.Attribute;

            DataRow row = dataTable.NewRow();
            row["№"] = 1;// (dataTable.Rows.Count+1).ToString();
            row["ФИО"] = _lastNameStudentTextBox.Text + "  " + _firstNameStudentTextBox.Text + "  " + _patromicStudentTextBox.Text;
            row["Пол"] = _maleRadioButton.Text;
            row["Группа"] = _studentGroupComboBox.Text;
            dataTable.Rows.Add(row);
            foreach (DataRow Drow in dataTable.Rows)
            {
                int num = StudentGroupDataGridView.Rows.Add();
                StudentGroupDataGridView.Rows[num].Cells[0].Value = Drow["№"].ToString();
                StudentGroupDataGridView.Rows[num].Cells[1].Value = Drow["ФИО"].ToString();
                StudentGroupDataGridView.Rows[num].Cells[2].Value = Drow["Пол"].ToString();
                StudentGroupDataGridView.Rows[num].Cells[3].Value = Drow["Группа"].ToString();
            }
            //       dataSet.Tables.Add(dataTable);                
            //      }
            //    StudentGroupDataGridView.DataSource = dataTable;
        }

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