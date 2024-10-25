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

namespace ProyectoCatedra
{
    /*Alberto Ramos Cruz - RC220772
Roberto José Melgares Zelaya - MZ221682
René Eduardo Hernández Castro - HC220857
Oscar Edgardo Navarro Banderas - NB220557
Fernando José Aquino Valle - AV220672*/
    public partial class InscribirMateriasView : Form
    {
        public MateriaList materiaApro;
        public MateriaList materiaIns;
        public Estudiante estudiate;
        public Materia[] materiaSin;
        public ColaInscripcion ColaIN = new ColaInscripcion();
        public MateriaCola cola;
        public Perfil prof = new Perfil();

        public InscribirMateriasView(Estudiante estudiante, MateriaList item, MateriaList item1, MateriaCola item2)
        {
            InitializeComponent();
            this.materiaApro = item;
            this.materiaIns = item1;
            this.estudiate = estudiante;
            this.cola = item2;
            VerificarCarrera veri = new VerificarCarrera();
            VerificarMaterias veri1 = new VerificarMaterias();
            label5.Text = veri.Verificar(estudiate.Carrera);
            Materia[] materias = materiaApro.CopyToArray();
            Materia[] materias1 = materiaIns.CopyToArray();
            materiaSin = veri1.EliminarMateriasRepetidas(materias, materias1);
            dataGridView1.DataSource = materias;
            dataGridView2.DataSource = materiaSin;
            checkedListBox1.DataSource = materiaSin.Select(x => x.Nombre).ToArray();
            int e = cola.Count();
            if (e > 0)
            {
                btnInscribir.Enabled = false;
            }
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            frminicio open = new frminicio(estudiate, materiaApro, materiaIns,cola);
            this.Hide();
            open.ShowDialog();
            this.Close();
        }
        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                foreach (string elemento in checkedListBox1.Items)
                {
                    if (checkedListBox1.CheckedItems.Contains(elemento))
                    {
                        Materia Aux = materiaSin.FirstOrDefault(materia => materia.Nombre == elemento);
                        cola.EnColar(Aux);

                    }
                }
                MessageBox.Show("Se ha inscrito correctamente las materias, porfavor inicia sesion nuevamente ", "Correcto");
                btnInscribir.Enabled = false;
            }
            else
            {
                MessageBox.Show("No a seleccionado ninguna materia a inscribir", "ERROR");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Agregar elementos a la cola
            // Recorrer la cola y mostrar cada elemento
            Materia[] incribir = cola.CopyToArray();
            foreach(Materia materia in incribir)
            {
                string querry = "INSERT INTO Inscripcion (CodigoMateria, Usuario, Estado) VALUES  ('" + materia.Codigo + "','" + estudiate.Carnet + "','Inscrita')";
                SqlCommand cmd = new SqlCommand(querry, Conexion.obtenerconexion());
                cmd.ExecuteNonQuery();
            }
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
