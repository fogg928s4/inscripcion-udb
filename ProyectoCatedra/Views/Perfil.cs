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
    public partial class Perfil : Form
    {
        public Estudiante Estudiante;
        public MateriaList MateriaApro;
        public MateriaList MateriasIns;
        public MateriaCola cola;
        public Perfil()
        {
            InitializeComponent();
        }
        public Perfil(Estudiante item, MateriaList item1, MateriaList item2, MateriaCola item3)
        {
            InitializeComponent();
            this.Estudiante = item;
            this.MateriaApro = item1;
            this.MateriasIns = item2;
            this.cola = item3;
            VerificarCarrera cr = new VerificarCarrera();
            txtNombre.Text = Estudiante.Nombre;
            txtApellido.Text = Estudiante.Apellido;
            txtCarnet.Text = Estudiante.Carnet;
            txtDireccion.Text = Estudiante.Direccion;
            txtNacimiento.Text = Estudiante.Nacimiento;
            txtTelefono.Text = Estudiante.Telefono;
            txtSexo.Text = Estudiante.Sexo;
            txtEmail.Text = Estudiante.Email;
            txtCarrera.Text = cr.Verificar(Estudiante.Carrera);

        }
        private void btnback_Click(object sender, EventArgs e)
        {
            frminicio inicio=new frminicio(Estudiante,MateriaApro, MateriasIns, cola);
            this.Hide();
            inicio.ShowDialog();
            this.Close();
        }
       

        private void btnSalir_Click(object sender, EventArgs e)
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
    }
}
