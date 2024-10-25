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

namespace ProyectoCatedra
{
    /*Alberto Ramos Cruz - RC220772
Roberto José Melgares Zelaya - MZ221682
René Eduardo Hernández Castro - HC220857
Oscar Edgardo Navarro Banderas - NB220557
Fernando José Aquino Valle - AV220672*/
    public partial class Tutores : Form
    {
        MateriaCola cola;
        Estudiante estudiante;
        public Tutores(MateriaCola item, Estudiante item2)
        {
            this.cola = item;
            this.estudiante = item2;
            InitializeComponent();
        }
        public Tutores()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Materia[] incribir = cola.CopyToArray();
            foreach (Materia materia in incribir)
            {
                string querry = "INSERT INTO Inscripcion (CodigoMateria, Usuario, Estado) VALUES  ('" + materia.Codigo + "','" + estudiante.Carnet + "','Inscrita')";
                SqlCommand cmd = new SqlCommand(querry, Conexion.obtenerconexion());
                cmd.ExecuteNonQuery();
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar desde qué formulario fue llamado
            if (this.Owner.GetType() == typeof(frminicio))
            {
                frminicio form1 = (frminicio)this.Owner;
                form1.Show();
            }
            else if (this.Owner.GetType() == typeof(FormAdmin))
            {
                FormAdmin form2 = (FormAdmin)this.Owner;
                form2.Show();
            }

            this.Close(); // Cerrar el formulario actual
        }
    }
}
