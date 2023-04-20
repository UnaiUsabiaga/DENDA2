using MySql.Data.MySqlClient;

namespace ERRONKA7
{
    public partial class AdminLogin : Form
    {
        String erabiltzailea = "administraria";
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void bItxiAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.loginForm.Show();
        }

        private void bAdminLogin_Click(object sender, EventArgs e)
        {
            Konexioa konexioa = new Konexioa();
            konexioEgokia(konexioa.konexioaBurutu(erabiltzailea, textPasahitza.Text));

 
            


        }
        private void konexioEgokia(Boolean konexioa)
        {
            if (konexioa == false)
            {
                MessageBox.Show("Konexioa ezin izan da burutu!");

                textPasahitza.Clear();
                textPasahitza.BorderStyle = BorderStyle.Fixed3D;
                textPasahitza.Select();
            }
            else
            {
                this.Hide();
                Program.adminMenuForm.Show();
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void bAdminLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textPasahitza_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}