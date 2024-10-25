using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
/*Alberto Ramos Cruz - RC220772
Roberto José Melgares Zelaya - MZ221682
René Eduardo Hernández Castro - HC220857
Oscar Edgardo Navarro Banderas - NB220557
Fernando José Aquino Valle - AV220672*/
namespace ProyectoCatedra
{
    public partial class frminicio : Form
    {
        public Estudiante Estudiante;
        public MateriaList MateriaApro;
        public MateriaList MateriasIns;
        public MateriaCola cola;
        public frminicio()
        {
            InitializeComponent();
        }
        public frminicio(Estudiante item,MateriaList item1, MateriaList item2,MateriaCola item3)
        {
            InitializeComponent();
            this.Estudiante = item;
            this.MateriaApro = item1;
            this.MateriasIns = item2;
            this.cola = item3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InscribirMateriasView open = new InscribirMateriasView(Estudiante, MateriaApro, MateriasIns, cola);
            this.Hide();
            open.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Perfil ventana = new Perfil(Estudiante,MateriaApro,MateriasIns,cola);
            this.Hide();
            ventana.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Materia[] incribir = cola.CopyToArray();
            foreach (Materia materia in incribir)
            {
                string querry = "INSERT INTO Inscripcion (CodigoMateria, Usuario, Estado) VALUES  ('" + materia.Codigo + "','" + Estudiante.Carnet + "','Inscrita')";
                SqlCommand cmd = new SqlCommand(querry, Conexion.obtenerconexion());
                cmd.ExecuteNonQuery();
            }
            this.Close();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            frminiciodesesion inicio=new frminiciodesesion();
            this.Hide();
            inicio.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tutores tut = new Tutores(cola,Estudiante);
            this.Hide();
            tut.ShowDialog(this); // Pasar el formulario actual como parámetro
        }
    }
}
