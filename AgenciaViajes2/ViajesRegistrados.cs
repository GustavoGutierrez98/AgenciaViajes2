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
    public partial class ViajesRegistrados : Form
    {
        public ViajesRegistrados()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroViajes registroViajes = new RegistroViajes();
            registroViajes.Show();
        }
    }
}
