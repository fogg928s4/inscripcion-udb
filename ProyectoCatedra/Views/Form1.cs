using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatedra
{
    public partial class frmportal : Form
    {
        public frmportal()
        {
            InitializeComponent();
            lb1.Focus();
        }

        private void btniniciodesesion_Click(object sender, EventArgs e)
        {
            frminiciodesesion send= new frminiciodesesion();
            this.Hide();
            send.ShowDialog();
            this.Close();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            frmregistro mostrar= new frmregistro();
            this.Hide();
            mostrar.ShowDialog();
            this.Close();
        }

        private void frmportal_Load(object sender, EventArgs e)
        {

        }
    }
}
