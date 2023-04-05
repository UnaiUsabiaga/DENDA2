using MySql.Data.MySqlClient;

namespace ERRONKA7
{
    
    public partial class langileaLogin : Form
    {
        String erabiltzailea = "langilea";
        public langileaLogin()
        {
            InitializeComponent();
        }

        private void bItxiLangilea_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.loginForm.Show();
        }

        private void bLangileaLogin_Click(object sender, EventArgs e)
        {
            Konexioa konexioa = new Konexioa();
            konexioEgokia(konexioa.konexioaBurutu(erabiltzailea, textLangilePasahitza.Text));
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
