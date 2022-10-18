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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
