using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaViajes2
{
    public partial class Destinos : Form
    {
        public Destinos()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login logi = new Login();
            logi.Show();
        }
    }
}
