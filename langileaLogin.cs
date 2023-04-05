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
        }

        private void bLangileaLogin_Click(object sender, EventArgs e)
        {
            Konexioa konexioa = new Konexioa();
            konexioa.konexioaBurutu(erabiltzailea, textLangilePasahitza.Text);
        }
    }
}
