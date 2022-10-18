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
    public partial class RegistroViajes : Form
    {
        public RegistroViajes()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Destinos desti = new Destinos();
            desti.Show();
        }
    }
}
