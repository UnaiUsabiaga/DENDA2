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

            comboBoxGailuMota.DataSource = null;

            string selectGailuMota = "SELECT gailuMota FROM gailumotataula";

            MySqlCommand cmd = new MySqlCommand(selectGailuMota, Konexioa.connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBoxGailuMota.DataSource = dt;
            comboBoxGailuMota.DisplayMember = "gailuMota";

            string selectMintegia = "SELECT izena FROM mintegitaula";

            comboBoxMintegia.DataSource = null;

            MySqlCommand cmd2 = new MySqlCommand (selectMintegia, Konexioa.connection);

            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd);

            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            comboBoxMintegia.DataSource = dt2;
            comboBoxMintegia.ValueMember = "idMintegia";
            comboBoxMintegia.DisplayMember = "izena";

        }
        private void datuakKargatu(string select)
        {
            // Konexioa.connection.Open();
            dataGridView1.DataSource = null;

            string sql = select;
            MySqlCommand cmd = new MySqlCommand(sql, Konexioa.connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void datuakBistaratu_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
