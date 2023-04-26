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
    public partial class adminMenu : Form
    {
        public adminMenu()
        {
            InitializeComponent();
        }

        private void btIrten_Click(object sender, EventArgs e)
        {
            this.Close();

            Program.adminLoginForm.Show();
        }

        private void BTdatuakBistaratu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.datuakBistaratuForm.Show();
        }

        private void BTdatuakEguneratu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.datuakForm.Show();
        }
    }
}