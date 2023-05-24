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
            //this.Close();
            this.Hide();
                //hide the form, not close to avoid problems reopening it
            Program.loginForm.Show();
                //show the next window form, datuak bistaratu
        }

        private void bLangileaLogin_Click(object sender, EventArgs e)
        {
            Konexioa konexioa = new Konexioa();//create a new connection
            konexioEgokia(konexioa.konexioaBurutu(erabiltzailea, textLangilePasahitza.Text));
                //call the connection function to prove it

            this.Hide();
                //hide the form, not close to avoid problems reopening it
            Program.datuakBistaratuForm.Show();
                //show the next window form, datuak bistaratu

        }
        private void konexioEgokia(Boolean konexioa)
        {
            if (konexioa == false)
            {       //if the connection fails, show a message to inform the user
                MessageBox.Show("Konexioa ezin izan da burutu!");
            }
        }
    }
}
