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
            // TODO: Implement label click event
        }

        private void bErregistroBerria_Load(object sender, EventArgs e)
        {
            // Load data when the form is loaded
            datuakKargatu();

            gailuMotakLortu();

            mintegiakLortu();

            erosketaDataPicker.MaxDate = DateTime.Now;
            //erosketaDataPicker.MinDate = "01/01/1960";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Close the current form and show the login form
            this.Hide();
            Program.loginForm.Show();
        }

        public void datuakKargatu()
        {
            // Konexioa.connection.Open();
            // Clear the data source of the DataGridView
            dataGridView1.DataSource = null;

            // Retrieve data from the product table
            string sql = "SELECT idProduktua, gailumota, marka, mintegia, modeloa, pantailaTamaina, deskribapena, kantitatea FROM produktutaula";

            MySqlCommand cmd = new MySqlCommand(sql, Konexioa.connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            // Set the retrieved data as the data source of the DataGridView
            dataGridView1.DataSource = dt;
        }

        private void gailuMotakLortu()
        {
            // Clear the data source of the ComboBox
            comboBoxGailuMota.DataSource = null;

            // Retrieve data for device types
            string selectGailuMota = "SELECT gailuMota FROM gailumotataula";

            MySqlCommand cmd = new MySqlCommand(selectGailuMota, Konexioa.connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            // Set the retrieved data as the data source of the ComboBox
            comboBoxGailuMota.DataSource = dt;
            comboBoxGailuMota.DisplayMember = "gailuMota";
            comboBoxGailuMota.ValueMember = "gailuMota";
            comboBoxGailuMota.SelectedItem = null;
        }

        private void mintegiakLortu()
        {
            // Retrieve data for stores
            string selectMintegia = "SELECT izena FROM mintegiTaula";

            // Clear the data source of the ComboBox
            cBoxMintegia.DataSource = null;

            MySqlCommand cmd2 = new MySqlCommand(selectMintegia, Konexioa.connection);

            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);

            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            // Set the retrieved data as the data source of the ComboBox
            cBoxMintegia.DataSource = dt2;
            cBoxMintegia.ValueMember = "izena";
            cBoxMintegia.DisplayMember = "izena";
        }

        private void btErregistroBerria_Click(object sender, EventArgs e)
        {
            // Get the values from the input fields
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

            // Create the insert query
            string insertSententzia = "INSERT INTO produktutaula (gailuMota, marka, modeloa, mintegia, pantailaTamaina, deskribapena, kantitatea, erosketaData) VALUES ('" + gailuMota + "','" + marka + "','" + modeloa + "','" + mintegia + "','" + pantailaTamaina + "','" + deskribapena + "','" + kantitatea + "','" + erosketaData + "')";

            MySqlCommand command = new MySqlCommand(insertSententzia, Konexioa.connection);

            try
            {
                // Execute the insert query
                command.ExecuteNonQuery();

                MessageBox.Show("Erregistroa ondo burutu da!");

                // Refresh the data in the DataGridView
                datuakKargatu();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Errorea izan da erregistroa burutzean: " + ex.Message);
            }

        }

        private void btDatuakBerritu_Click(object sender, EventArgs e)
        {
            // Get the selected product ID from the DataGridView
            String idProduktua = "";
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                idProduktua = Convert.ToString(selectedRow.Cells["idProduktua"].Value);
            }

            // Get the values from the input fields
            String gailuMota = comboBoxGailuMota.Text;
            String marka = txtMarka.Text;
            String modeloa = txtModeloa.Text;
            String erosketaData = erosketaDataPicker.Value.Year + "-" + erosketaDataPicker.Value.Month + "-" + erosketaDataPicker.Value.Day;
            String mintegia = cBoxMintegia.Text;
            String kantitatea = txtKantitatea.Text;
            String pantailaTamaina = txtPantaila.Text;
            String deskribapena = txtDeskribapena.Text;

            // Create the update query
            String updateSententzia = "UPDATE produktutaula SET gailumota='" + gailuMota + "' AND marka ='" + marka + "' AND mintegia ='" + mintegia + "' AND modeloa ='" + modeloa + "' AND pantailaTamaina ='" + pantailaTamaina + "' AND deskribapena ='" + deskribapena + "' AND kantitatea ='" + kantitatea + "' WHERE idProduktua ='" + idProduktua + "';";

            MySqlCommand command = new MySqlCommand(updateSententzia, Konexioa.connection);

            try
            {
                // Execute the update query
                command.ExecuteNonQuery();

                MessageBox.Show("Erregistroa ondo burutu da!");

                // Refresh the data in the DataGridView
                datuakKargatu();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Errorea izan da erregistroa burutzean: " + ex.Message);
            }
        }

        private void btBajaEman_Click(object sender, EventArgs e)
        {
            // TODO: Implement "BajaEman" button click event
        }
    }
}

