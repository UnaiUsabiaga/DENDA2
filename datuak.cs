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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ERRONKA7
{
    public partial class bErregistroBerria : Form
    {
        public bErregistroBerria()
        {
            InitializeComponent();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void bErregistroBerria_Load(object sender, EventArgs e)
        {
            datuakKargatu();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

            Program.loginForm.Show();
        }
        private void datuakKargatu()
        {
            // Konexioa.connection.Open();
            dataGridView1.DataSource = null;

            string sql = "SELECT idProduktua,izena,modeloa,pantailaTamaina,deskribapena FROM produktutaula";
            MySqlCommand cmd = new MySqlCommand(sql, Konexioa.connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btErregistroBerria_Click(object sender, EventArgs e)
        {
            string izena = txtIzena.Text;
            string modeloa = txtModeloa.Text;
            int kantitatea = listBoxKantitatea.SelectedIndex;
            string pantailaTamaina = txtPantaila.Text;
            string deskribapena = txtDeskribapena.Text;
            string mintegia = listBoxMintegi.Text;


            string insertSententzia = "INSERT INTO produktutaula (izena,idMarka,idMintegia,modeloa,pantailaTamaina,deskribapena,Kantitatea) VALUES ('"+ izena+ "','"+modeloa+"','"+mintegia+"','"+pantailaTamaina+"','"+deskribapena+"','"+kantitatea+"')";

            MySqlCommand command = new MySqlCommand(insertSententzia,Konexioa.connection);

            try
            {
                command.ExecuteNonQuery();

                MessageBox.Show("Erregistroa ondo burutu da!");

                datuakKargatu();

            }
            catch
            {
                MessageBox.Show("Errorea izan da erregistroa burutzean");
            }
            
    
        }
    }
}
