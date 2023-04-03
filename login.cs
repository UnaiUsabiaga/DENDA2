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
            Form AdminLogin = new AdminLogin();

            AdminLogin.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {
            //holsa
        }
    }
}