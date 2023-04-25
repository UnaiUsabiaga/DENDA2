using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class datuakBistaratu : Form
    {
        public datuakBistaratu()
        {
            InitializeComponent();

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

            comboBoxMintegia.SelectedItem = null;

            dataGridBistaratu.DataSource = null;

            string selectDataGrid = "SELECT * FROM produktutaula";

            MySqlCommand cmd5 = new MySqlCommand(selectDataGrid, Konexioa.connection);
            MySqlDataAdapter da5 = new MySqlDataAdapter(cmd5);

            DataTable dt5 = new DataTable();
            da5.Fill(dt5);

            dataGridBistaratu.DataSource = dt5;


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
            try
            {
                comboBoxGailuMota.SelectedItem = null;
                comboBoxMintegia.SelectedItem = null;
                dataGridBistaratu.DataSource = null;
                comboBoxEzaugarria.DisplayMember = null;

                hasieraData.Hide();
                hasieraDataPicker.Hide();
                amaieraData.Hide();
                amaieraDataPicker.Hide();
            }
            catch (NullReferenceException)
            {


            }
            string consultaSql = "SELECT * FROM produktutaula";
        }
        private void comboBoxGailuMota_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBoxGailuMota.SelectedItem == null)
            //{
            //    datuakKargatu();
            //}
            //else
            //{
            //    string strGailuMota = comboBoxGailuMota.SelectedItem.ToString();

            //    //string selectDataGrid = "SELECT * FROM produktutaula WHERE gailuMota ="+ strGailuMota;

            //    string selectDataGrid = "SELECT * FROM produktutaula";

            //    datuTaulaKargatu(selectDataGrid);
            //}
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
            string selectEzaugarria = "SELECT marka,modeloa,pantailaTamaina,kantitatea,erosketaData FROM produktutaula";

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
            if (comboBoxGailuMota.SelectedItem != null)
            {
                comboBoxEzaugarriPosibleak.DataSource = null;
                string ezaugarriAukeraketa = comboBoxEzaugarria.SelectedItem.ToString();
                string gailuMotaAukeraketa = comboBoxGailuMota.SelectedValue.ToString();

                string selectEzaugarriPosibleak = "SELECT DISTINCT " + ezaugarriAukeraketa + " FROM produktutaula WHERE gailuMota = '" + gailuMotaAukeraketa + "'";


                MySqlCommand cmd4 = new MySqlCommand(selectEzaugarriPosibleak, Konexioa.connection);

                MySqlDataAdapter da4 = new MySqlDataAdapter(cmd4);

                DataTable dt4 = new DataTable();
                da4.Fill(dt4);
                comboBoxEzaugarriPosibleak.DataSource = dt4;

                comboBoxEzaugarriPosibleak.DisplayMember = comboBoxEzaugarria.SelectedItem.ToString();
            }
        }

        private void btBistaratu_Click(object sender, EventArgs e)
        {
            string selectgailuMota = "";
            string selectEzaugarria = "";
            string consultaSql = "SELECT * FROM produktutaula";

            if (comboBoxGailuMota.SelectedValue != null)
            {
                selectgailuMota = comboBoxGailuMota.SelectedValue.ToString();

                // Hautatutako balioari dagokion WHERE klausea barne hartzen duen SQL kontsulta sortu
                consultaSql = "SELECT gailuMota,marka,mintegia,modeloa,pantailaTamaina,deskribapena,kantitatea,erosketaData FROM produktutaula WHERE gailuMota = @gailuMota";

                if (comboBoxMintegia.SelectedValue != null)
                {
                    //string mintegia = comboBoxMintegia.SelectedItem.ToString();
                    string mintegia = comboBoxMintegia.Text;
                    consultaSql = "SELECT gailuMota,marka,mintegia,modeloa,pantailaTamaina,deskribapena,kantitatea,erosketaData FROM produktutaula WHERE gailuMota = @gailuMota AND mintegia='" + mintegia + "'";

                }

                if (comboBoxEzaugarria.SelectedItem != null)
                {
                    selectEzaugarria = comboBoxEzaugarria.Text;
                    string ezaugarriPosiblea = comboBoxEzaugarriPosibleak.Text;

                    consultaSql = "SELECT gailuMota,marka,mintegia,modeloa,pantailaTamaina,deskribapena,kantitatea,erosketaData FROM produktutaula WHERE gailuMota = @gailuMota AND " + selectEzaugarria + "='" + ezaugarriPosiblea + "'";

                    if (comboBoxMintegia.SelectedValue != null)
                    {
                        //string mintegia = comboBoxMintegia.SelectedItem.ToString();
                        string mintegia = comboBoxMintegia.Text;
                        consultaSql = "SELECT gailuMota,marka,mintegia,modeloa,pantailaTamaina,deskribapena,kantitatea,erosketaData FROM produktutaula WHERE gailuMota = @gailuMota AND " + selectEzaugarria + "='" + ezaugarriPosiblea + "' AND mintegia='" + mintegia + "'";

                    }
                }

            }
            else if (hasieraDataPicker.Value != hasieraDataPicker.Value.ToLocalTime())
            {
                string hasieraData = hasieraDataPicker.Value.Year + "-" + hasieraDataPicker.Value.Month + "-" + hasieraDataPicker.Value.Day;

                string amaieraData = amaieraDataPicker.Value.Year + "-" + amaieraDataPicker.Value.Month + "-" + amaieraDataPicker.Value.Day;

                consultaSql = "SELECT gailuMota,marka,mintegia,modeloa,pantailaTamaina,deskribapena,kantitatea,erosketaData FROM produktutaula WHERE erosketaData BETWEEN '" + hasieraData + "' AND '" + amaieraData + "'";

            }

            else if (comboBoxMintegia.SelectedValue != null)
            {
                //string mintegia = comboBoxMintegia.SelectedItem.ToString();
                string mintegia = comboBoxMintegia.Text;
                consultaSql = "SELECT gailuMota,marka,mintegia,modeloa,pantailaTamaina,deskribapena,kantitatea,erosketaData FROM produktutaula WHERE mintegia = '" + mintegia + "'";
            }

            // SQL komando objektu bat sortu eta kontsultaSql-en parametroa gehitu
            MySqlCommand komandoa = new MySqlCommand(consultaSql, Konexioa.connection);
            komandoa.Parameters.AddWithValue("@gailuMota", selectgailuMota);
            komandoa.Parameters.AddWithValue("@ezaugarria", selectEzaugarria);

            // DataAdapter objektu bat sortu eta DataTable objektu bat datu egituraz betetzeko SQL komando objektua erabiliz
            MySqlDataAdapter adapter = new MySqlDataAdapter(komandoa);
            DataTable taula = new DataTable();
            adapter.Fill(taula);

            dataGridBistaratu.DataSource = taula;
        }

        private void comboBoxEzaugarria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ezaugarriPosibleakLortu();

            comboBoxEzaugarriPosibleak.Show();

            try
            {
                if (comboBoxEzaugarria.SelectedItem == null)
                {
                    comboBoxEzaugarria = null;
                }
                else if (comboBoxEzaugarria.SelectedItem.ToString() == "erosketaData" && comboBoxEzaugarria.SelectedItem.ToString() != null)
                {
                    comboBoxEzaugarriPosibleak.Hide();
                    hasieraData.Show();
                    hasieraDataPicker.Show();
                    amaieraData.Show();
                    amaieraDataPicker.Show();
                }
                else
                {
                    hasieraData.Hide();
                    hasieraDataPicker.Hide();
                    amaieraData.Hide();
                    amaieraDataPicker.Hide();
                }

            }
            catch (Exception NullReferenceException)
            {
                if (comboBoxEzaugarria.SelectedItem.ToString == null)
                {
                    hasieraData.Hide();
                    hasieraDataPicker.Hide();
                    amaieraData.Hide();
                    amaieraDataPicker.Hide();
                }
            }



        }

        private void bajaEmandaErakutsi_CheckStateChanged(object sender, EventArgs e)
        {

            dataGridBistaratu.DataSource = null;

            string consultaSql = "SELECT * FROM produktutaula WHERE bajanDago ='EZ'";

            MySqlCommand cmd5 = new MySqlCommand(consultaSql, Konexioa.connection);
            MySqlDataAdapter da5 = new MySqlDataAdapter(cmd5);

            DataTable dt5 = new DataTable();
            da5.Fill(dt5);

            dataGridBistaratu.DataSource = dt5;
        }
    }
}
