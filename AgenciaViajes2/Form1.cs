namespace AgenciaViajes2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Destinos desti = new Destinos();
            desti.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Noticias noti = new Noticias();
            noti.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViajesRegistrados vr = new ViajesRegistrados();
            vr.Show();
        }
    }
}