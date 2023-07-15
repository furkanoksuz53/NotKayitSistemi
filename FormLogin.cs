namespace NotKayitSistemi
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormStudentDetail formStudentDetail = new FormStudentDetail();
            formStudentDetail.number = Convert.ToInt32(maskedTextBox1.Text);
            formStudentDetail.Show();

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(maskedTextBox1.Text == "626")
            {
                FormTeacherDetail form=new FormTeacherDetail();
                form.Show();
            }
        }
    }
}