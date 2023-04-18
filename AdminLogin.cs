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

            Program.datuakForm.Show();
            this.Hide();
            

        }

        private void textPasahitza_Leave(object sender, EventArgs e)
        {
            //Konexioa konexioa = new Konexioa();

            //konexioEgokia(konexioa.konexioaBurutu(erabiltzailea, textPasahitza.Text));
        }
        private void konexioEgokia(Boolean konexioa)
        {
            if (konexioa == false)
            {
                MessageBox.Show("Konexioa ezin izan da burutu!");
            }
        }

    }
}