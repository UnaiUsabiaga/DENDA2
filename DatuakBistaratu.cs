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
    public partial class datuakBistaratu : Form
    {
        public datuakBistaratu()
        {
            InitializeComponent();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bajaEmandaErakutsi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void datuakBistaratu_Load(object sender, EventArgs e)
        {
            gailuMotakLortu();

            mintegiakLortu();

            ezaugarriakLortu();

            ezaugarriPosibleakLortu();

            

            dataGridBistaratu.DataSource = null;

            string selectDataGrid = "SELECT * FROM produktutaula";

            MySqlCommand cmd5 = new MySqlCommand(selectDataGrid, Konexioa.connection);
            MySqlDataAdapter da5 = new MySqlDataAdapter(cmd5);

            DataTable dt5 = new DataTable();
            da5.Fill(dt5);

            dataGridBistaratu.DataSource = dt5;


        }
        private void datuakKargatu(string select)
        {

            dataGridBistaratu.DataSource = null;

            string sql = select;
            MySqlCommand cmd = new MySqlCommand(sql, Konexioa.connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridBistaratu.DataSource = dt;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void datuakKargatu()
        {
            // Konexioa.connection.Open();
            dataGridBistaratu.DataSource = null;

            string sql = "SELECT idProduktua,gailuMota,marka,mintegia,modeloa,pantailaTamaina,kantitatea,deskribapena,kantitatea,erosketaData FROM produktutaula";

            MySqlCommand cmd = new MySqlCommand(sql, Konexioa.connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridBistaratu.DataSource = dt;
        }

        private void datuakBistaratu_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btIrten_Click(object sender, EventArgs e)
        {
            this.Close();

            Program.loginForm.Show();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            comboBoxGailuMota.SelectedItem = null;
            comboBoxEzaugarria.SelectedItem = null;
            comboBoxMintegia.SelectedItem = null;
        }

        private void comboBoxGailuMota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGailuMota.SelectedItem == null)
            {
                datuakKargatu();
            }
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
            comboBoxGailuMota.SelectedItem = null;
        }

        private void mintegiakLortu()
        {
            string selectMintegia = "SELECT izena FROM mintegiTaula";

            comboBoxMintegia.DataSource = null;

            MySqlCommand cmd2 = new MySqlCommand(selectMintegia, Konexioa.connection);

            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);

            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            comboBoxMintegia.DataSource = dt2;

            comboBoxMintegia.DisplayMember = "izena";
        }

        private void ezaugarriakLortu()
        {
            string selectEzaugarria = "SELECT * FROM produktutaula";

            comboBoxEzaugarria.DataSource = null;

            MySqlCommand cmd3 = new MySqlCommand(selectEzaugarria, Konexioa.connection);

            MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);

            DataTable dt3 = new DataTable();
            da3.Fill(dt3);

            for (int i = 0; i < dt3.Columns.Count; i++)
            {
                comboBoxEzaugarria.Items.Add(dt3.Columns[i].ColumnName);
            }
        }

        private void ezaugarriPosibleakLortu()
        {
            comboBoxEzaugarriPosibleak.DataSource = null;

            string selectEzaugarriPosibleak = "SELECT DISTINCT @ezaugarria FROM produktutaula WHERE gailuMota = @gailuMota";


            MySqlCommand cmd4 = new MySqlCommand(selectEzaugarriPosibleak, Konexioa.connection);
            cmd4.Parameters.AddWithValue("@ezaugarria", comboBoxEzaugarria.Text);
            cmd4.Parameters.AddWithValue("@gailuMota", comboBoxGailuMota.Text);

            MySqlDataAdapter da4 = new MySqlDataAdapter(cmd4);

            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            comboBoxEzaugarriPosibleak.DataSource = dt4;

            comboBoxEzaugarriPosibleak.DisplayMember = comboBoxEzaugarria.Text;

        }
    }
}
