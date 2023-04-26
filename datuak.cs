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

            mintegiakLortu();

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

            string sql = "SELECT idProduktua,gailumota,marka,mintegia,modeloa,pantailaTamaina,deskribapena,kantitatea,bajanDago FROM produktutaula";

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
        private void mintegiakLortu()
        {
            string selectMintegia = "SELECT izena FROM mintegiTaula";

            cBoxMintegia.DataSource = null;

            MySqlCommand cmd2 = new MySqlCommand(selectMintegia, Konexioa.connection);

            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);

            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            cBoxMintegia.DataSource = dt2;
            cBoxMintegia.ValueMember = "izena";
            cBoxMintegia.DisplayMember = "izena";
        }

        private void btErregistroBerria_Click(object sender, EventArgs e)
        {

            string modeloa = txtModeloa.Text;

            string deskribapena = txtDeskribapena.Text;
            string marka = txtMarka.Text;
            string gailuMota = comboBoxGailuMota.SelectedValue.ToString();
            string pantailaTamaina = "";

            if (txtPantaila.Text != null)
            {
                pantailaTamaina = txtPantaila.Text;
            }
            else
            {
                pantailaTamaina = "";
            }

            string mintegia = "";
            if (cBoxMintegia.SelectedValue.ToString() != null)
            {
                mintegia = cBoxMintegia.SelectedValue.ToString();
            }

            string kantitatea = "";
            if (txtKantitatea.Text != null)
            {
                kantitatea = txtKantitatea.Text.ToString();
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

        private void btDatuakBerritu_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            string idProduktua = row.Cells["idProduktua"].Value.ToString();

            string modeloa = txtModeloa.Text;
            string deskribapena = txtDeskribapena.Text;
            string marka = txtMarka.Text;
            string gailuMota = comboBoxGailuMota.SelectedValue.ToString();
            string pantailaTamaina = "";

            if (txtPantaila.Text != null)
            {
                pantailaTamaina = txtPantaila.Text;
            }
            else
            {
                pantailaTamaina = "";
            }

            string mintegia = "";
            if (cBoxMintegia.SelectedValue.ToString() != null)
            {
                mintegia = cBoxMintegia.SelectedValue.ToString();
            }

            string kantitatea = "";
            if (txtKantitatea.Text != null)
            {
                kantitatea = txtKantitatea.Text.ToString();
            }

            string erosketaData = erosketaDataPicker.Value.Year + "-" + erosketaDataPicker.Value.Month + "-" + erosketaDataPicker.Value.Day;

            string updateSententzia = "UPDATE produktutaula SET gailuMota = '" + gailuMota + "',marka = '" + marka + "',mintegia = '" + mintegia + "',modeloa = '" + modeloa + "',pantailaTamaina = '" + pantailaTamaina + "',deskribapena = '" + deskribapena + "',kantitatea = '" + kantitatea + "',erosketaData='" + erosketaData + "' WHERE idProduktua = '" + idProduktua + "'; ";


            MySqlCommand command = new MySqlCommand(updateSententzia, Konexioa.connection);
            try
            {
                command.ExecuteNonQuery();

                MessageBox.Show("Datuak ondo berritu dira!");

                datuakKargatu();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Errorea izan da datuak berritzean: " + ex.Message);
            }



        }

        private void btBajaEman_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            string idProduktua = row.Cells["idProduktua"].Value.ToString();

            string updateSententzia = "UPDATE produktutaula SET bajanDago='BAI' WHERE idProduktua= '"+idProduktua+"';";
            
            MySqlCommand command = new MySqlCommand(updateSententzia, Konexioa.connection);
            try
            {
                command.ExecuteNonQuery();

                MessageBox.Show("Baja ondo burutu da!");

                datuakKargatu();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Errorea izan da baja: " + ex.Message);
            }
        }
    }

}
