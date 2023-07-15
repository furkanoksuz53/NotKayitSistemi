using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotKayitSistemi
{
    public partial class FormTeacherDetail : Form
    {
        public FormTeacherDetail()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NotKayit;");

        public void GetData()
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Select * from tbl_Lesson", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_Lesson (StudentNumber,StudentName,StudentSurname) values (@P1,@P2,@P3)", sqlConnection);
            cmd.Parameters.AddWithValue("@P1", tbxStdNum.Text);
            cmd.Parameters.AddWithValue("@P2", tbxStdName.Text);
            cmd.Parameters.AddWithValue("@P3", tbxStdSurname.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Öğrenci Eklendi");
            GetData();
        }

        private void FormTeacherDetail_Load(object sender, EventArgs e)
        {
            GetData();
            SuccessStudentsCount();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
            tbxStdNum.Text = dataGridView1.Rows[selectedIndex].Cells[1].Value.ToString();
            tbxStdName.Text = dataGridView1.Rows[selectedIndex].Cells[2].Value.ToString();
            tbxStdSurname.Text = dataGridView1.Rows[selectedIndex].Cells[3].Value.ToString();
            tbxNot1.Text = dataGridView1.Rows[selectedIndex].Cells[4].Value.ToString();
            tbxNot2.Text = dataGridView1.Rows[selectedIndex].Cells[5].Value.ToString();
            tbxNot3.Text = dataGridView1.Rows[selectedIndex].Cells[6].Value.ToString();
            decimal not1 = Convert.ToInt32(tbxNot1.Text);
            decimal not2 = Convert.ToInt32(tbxNot2.Text);
            decimal not3 = Convert.ToInt32(tbxNot3.Text);
            decimal ort = (not1 + not2 + not3) / 3;

            lblAverage.Text = ort.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal not1 = Convert.ToInt32(tbxNot1.Text);
            decimal not2 = Convert.ToInt32(tbxNot2.Text);
            decimal not3 = Convert.ToInt32(tbxNot3.Text);
            decimal average = (not1 + not2 + not3) / 3;
            bool statu = average >= 50 ? true : false;
            lblAverage.Text = average.ToString();

            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("update tbl_Lesson set Not1=@p1,Not2=@p2,Not3=@p3,Average=@p4,Status=@p5 where StudentNumber=@p6", sqlConnection);
            cmd.Parameters.AddWithValue("@p1", tbxNot1.Text);
            cmd.Parameters.AddWithValue("@p2", tbxNot2.Text);
            cmd.Parameters.AddWithValue("@p3", tbxNot3.Text);
            cmd.Parameters.AddWithValue("@p4", decimal.Parse(lblAverage.Text));
            cmd.Parameters.AddWithValue("@p5", statu);
            cmd.Parameters.AddWithValue("@p6", tbxStdNum.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            GetData();
            SuccessStudentsCount();

        }
        public void SuccessStudentsCount()
        {
            int sucCount = 0;
            int studentCount = dataGridView1.Rows.Count;
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Select * from tbl_Lesson where Average>=50", sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sucCount++;
            }
            sqlConnection.Close();
            lblSuccessCount.Text = sucCount.ToString();
            int failCount = studentCount - sucCount-1;
            lblFailCount.Text = failCount.ToString();
        }
    }
}
