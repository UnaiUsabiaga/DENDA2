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

        private void bErregistroBerria_Load(object sender, EventArgs e)
        {
            datuakKargatu();

            gailuMotakLortu();

            erosketaDataPicker.MaxDate = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

            Program.loginForm.Show();
        }
        public void datuakKargatu()
        {
            // Konexioa.connection.Open();
            dataGridView1.DataSource = null;

            string sql = "SELECT gailumota,marka,mintegia,modeloa,pantailaTamaina,deskribapena,kantitatea FROM produktutaula";

            MySqlCommand cmd = new MySqlCommand(sql, Konexioa.connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void gailuMotakLortu()
        {
            comboBoxGailuMota.DataSource = null;

            string selectGailuMota = "SELECT gailuMota FROM gailumotataula";

            MySqlCommand cmd = new MySqlCommand(selectGailuMota, Konexioa.connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBoxGailuMota.DataSource = dt;
            comboBoxGailuMota.DisplayMember = "gailuMota";
            comboBoxGailuMota.ValueMember = "gailuMota";
            comboBoxGailuMota.SelectedItem = null;
        }

        private void btErregistroBerria_Click(object sender, EventArgs e)
        {

            string modeloa = txtModeloa.Text;
            string pantailaTamaina = txtPantaila.Text;
            string deskribapena = txtDeskribapena.Text;
            string marka = txtMarka.Text;
            string gailuMota = comboBoxGailuMota.SelectedValue.ToString();

            string mintegia = "";
            if (listBoxMintegi.SelectedItem != null)
            {
                mintegia = listBoxMintegi.SelectedItem.ToString();
            }

            string kantitatea = "";
            if (listBoxKantitatea.SelectedItem != null)
            {
                kantitatea = listBoxKantitatea.SelectedValue.ToString();
            }

            string erosketaData = erosketaDataPicker.Value.Year + "-" + erosketaDataPicker.Value.Month + "-" + erosketaDataPicker.Value.Day;


            string insertSententzia = "INSERT INTO produktutaula (gailuMota,marka,modeloa,mintegia,pantailaTamaina,deskribapena,kantitatea,erosketaData) VALUES ('" + gailuMota + "','" + marka + "','" + modeloa + "','" + mintegia + "','" + pantailaTamaina + "','" + deskribapena + "','" + kantitatea + "','" + erosketaData + "')";

            MySqlCommand command = new MySqlCommand(insertSententzia, Konexioa.connection);

            try
            {
                command.ExecuteNonQuery();

                MessageBox.Show("Erregistroa ondo burutu da!");

                datuakKargatu();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Errorea izan da erregistroa burutzean: " + ex.Message);
            }


        }
    }
}
