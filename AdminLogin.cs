using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERRONKA7
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void bItxiAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAdminLogin_Click(object sender, EventArgs e)
        {
            konexioBurutu();
        }

        private void textPasahitza_Leave(object sender, EventArgs e)
        {
            konexioBurutu();
        }

        private void konexioBurutu()
        {
            string strPasahitza = textPasahitza.Text;

            string connectionString = "server=localhost;port=3306;database=db_erronka7;uid=administraria;password=" + strPasahitza;

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Konexioa burutu da!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pasahitz OKERRA!");
            }
            finally
            {
                connection.Close();
            }

        }
    }
}