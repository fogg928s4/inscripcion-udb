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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlumnosView mostrar = new AlumnosView();
            this.Hide();
            mostrar.ShowDialog();
            this.Close();
        }
        private void btnregresar_Click_1(object sender, EventArgs e)
        {
            frminiciodesesion mostrar = new frminiciodesesion();
            this.Hide();
            mostrar.ShowDialog();
            this.Close();
        }

        private void btnout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tutores tut = new Tutores();
            this.Hide();
            tut.ShowDialog(this); // Pasar el formulario actual como parámetro
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PerfilAlumnos alumnos = new PerfilAlumnos();
            this.Hide();
            alumnos.ShowDialog(this);
            this.Close();
        }
    }
}
