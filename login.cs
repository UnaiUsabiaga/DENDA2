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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form langileaLogin = new langileaLogin();

            langileaLogin.Show();
        }
    }
}