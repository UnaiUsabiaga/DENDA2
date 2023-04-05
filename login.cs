using MySql.Data.MySqlClient;

namespace ERRONKA7
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

        }

        private void bAdmin_Click(object sender, EventArgs e)
        {
            Program.adminLoginForm = new AdminLogin();

            Program.adminLoginForm.Show();
            Program.loginForm.Hide();

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.langileaLoginForm = new langileaLogin();

            Program.langileaLoginForm.Show();
            Program.loginForm.Hide();
        }
    }
}