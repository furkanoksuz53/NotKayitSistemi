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
    public partial class FormStudentDetail : Form
    {
        public int number;
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NotKayit;");

        public FormStudentDetail()
        {
            InitializeComponent();
        }


        private void FormStudentDetail_Load(object sender, EventArgs e)
        {
            lblStdNum.Text = number.ToString();
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("Select * from tbl_Lesson where StudentNumber=@p1", sqlConnection);
            cmd.Parameters.AddWithValue("@p1", number);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                lblStdName.Text = reader[2].ToString()+" " + reader[3].ToString();
                lblNot1.Text = reader[4].ToString();
                lblNot2.Text = reader[5].ToString();
                lblNot3.Text = reader[6].ToString();
                lblAvrg.Text = reader[7].ToString();
                lblStatu.Text = reader[8].ToString()=="True"? "Geçti":"Kaldı";

            }
            sqlConnection.Close();
        }

    }
}
