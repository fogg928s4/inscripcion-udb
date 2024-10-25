using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoCatedra.Clases;
using ProyectoCatedra.Controlador;
/*Alberto Ramos Cruz - RC220772
Roberto José Melgares Zelaya - MZ221682
René Eduardo Hernández Castro - HC220857
Oscar Edgardo Navarro Banderas - NB220557
Fernando José Aquino Valle - AV220672*/
namespace ProyectoCatedra
{
    public partial class PerfilAlumnos : Form
    {
        public PerfilAlumnos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FormAdmin nuevo = new FormAdmin();
            this.Hide();
            nuevo.ShowDialog();
            this.Close();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            NodoEstudianteL nodo = ColaGlobal.Colainscripcion.Dequeue();
            if (nodo == null)
            {
                MessageBox.Show("La cola está vacía.");
            }
            else
            {
                ActualizarEstudiante(nodo);
            }
        }
        private void ActualizarEstudiante(NodoEstudianteL nodoactual)
        {
            //Asigna a los campos de textos los datos del nodo actual
            txtnombre.Text = nodoactual.infonodo.Nombre;
            txtapellido.Text = nodoactual.infonodo.Apellido;
            txtcarrera.Text = nodoactual.infonodo.Carrera.ToString();
            txtcarnet.Text = nodoactual.infonodo.Carnet;
            txttelefono.Text = nodoactual.infonodo.Telefono;
            txtemail.Text = nodoactual.infonodo.Email;   
            txtdireccion.Text = nodoactual.infonodo.Direccion;
            txtfechadenacimiento.Text = nodoactual.infonodo.Nacimiento;
        }
        private void PerfilAlumnos_Load(object sender, EventArgs e)
        {
            //Se encarga de borrar los objetos hasta el punto que esta llegue null
            //Ya que va recorriendo la cola y vaciando los datos
            NodoEstudianteL nodo = ColaGlobal.Colainscripcion.Dequeue();
            if (nodo==null)
            {
                MessageBox.Show("La cola está vacía.");
            }
            else
            {
                ActualizarEstudiante(nodo);
            }
        }
    }
}
