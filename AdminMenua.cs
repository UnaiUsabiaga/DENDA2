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
                //this.Close();
            this.Hide();
                //hide the form, not close to avoid problems reopening it
            Program.adminLoginForm.Show();
                //show the past window form, admin login
        }

        private void BTdatuakBistaratu_Click(object sender, EventArgs e)
        {
            
            Program.datuakBistaratuForm.Show();
                //show the next window form, datuak bistaratu
            this.Hide();
                //hide the form, not close to avoid problems reopening it
        }

        private void BTdatuakEguneratu_Click(object sender, EventArgs e)
        {
            this.Hide();
                //hide the form, not close to avoid problems reopening it
            Program.datuakForm.Show();
                //show the next window form, datuak bistaratu
        }
    }
}