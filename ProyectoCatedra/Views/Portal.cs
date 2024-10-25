using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Alberto Ramos Cruz - RC220772
Roberto José Melgares Zelaya - MZ221682
René Eduardo Hernández Castro - HC220857
Oscar Edgardo Navarro Banderas - NB220557
Fernando José Aquino Valle - AV220672*/

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


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 invitado = new Form1();
            this.Hide();
            invitado.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmregistro mostrar = new frmregistro();
            this.Hide();
            mostrar.ShowDialog();
            this.Close();
        }
    }
}
