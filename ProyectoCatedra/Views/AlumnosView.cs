using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Alberto Ramos Cruz - RC220772
Roberto José Melgares Zelaya - MZ221682
René Eduardo Hernández Castro - HC220857
Oscar Edgardo Navarro Banderas - NB220557
Fernando José Aquino Valle - AV220672*/

namespace ProyectoCatedra
{
    public partial class AlumnosView : Form
    {
        ListaEstudiantes listreader = new ListaEstudiantes();
        public AlumnosView()
        {

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*frminicio open = new frminicio();
            open.Show();
            this.Close();*/
        }

        private void AlumnosVista_Load(object sender, EventArgs e)
        {

            string query = "SELECT * FROM Usuario WHERE ID != 5";
            SqlCommand command = new SqlCommand(query, Conexion.obtenerconexion());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Estudiante show = new Estudiante();
                show.Carnet = (string)reader["Usuario"];
                show.Nombre = (string)reader["Nombres"];
                show.Apellido = (string)reader["Apellidos"];
                show.Nacimiento = (string)reader["Nacimiento"];
                show.Email = (string)reader["Email"];
                show.Telefono = (string)reader["Telefono"];
                show.Direccion = (string)reader["Direccion"];
                show.Dui = (string)reader["Dui"];
                show.Carrera = (int)reader["ID"];
                show.Sexo = (string)reader["SEXO"];
                listreader.InsertarF(show);
            }
            Estudiante[] arregloshow = listreader.CopyToArray();
            this.dgv2.DataSource = arregloshow;
            this.dgv2.Refresh();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            FormAdmin mostrar = new FormAdmin();
            mostrar.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = null;
            bool encontrado = false;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ingrese un carnet para buscar");
                textBox1.Focus();
            }
            else if (!Regex.IsMatch(textBox1.Text, @"^[a-zA-Z0-9]*$"))
            {
                MessageBox.Show("El carnet está en un formato no válido.");
                textBox1.Focus();
            }
            else 
            {
                string valorBusqueda = textBox1.Text;

                foreach (DataGridViewRow fila in dgv2.Rows)
                {
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        if (celda.Value != null && celda.Value.ToString().Contains(valorBusqueda))
                        {
                            fila.DefaultCellStyle.BackColor = Color.Yellow;
                            encontrado = true;
                            break;
                        }
                    }
                }
                if (!encontrado)
                {
                    MessageBox.Show("No se encontro el alumno");
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox1.Text = "Ejemplo: AA110556";
                textBox1.ForeColor = SystemColors.GrayText;
            }
            textBox1.Text = textBox1.Text.ToUpper();
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ejemplo: AA110556")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.WindowText;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgv2.Rows)
            {
                foreach (DataGridViewCell celda in fila.Cells)
                {

                    fila.DefaultCellStyle.BackColor = Color.White;

                }
            }
            this.dgv2.Refresh();
        }
    }
}
