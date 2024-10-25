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
    public partial class Pensum : Form
    {
        MateriaList materiasC = new MateriaList();
        int carrera;
        public Pensum(int carre)
        {

            InitializeComponent();
            this.carrera = carre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 mostrar = new Form1();
            this.Hide();
            mostrar.ShowDialog();
            this.Close();
        }

        private void Pensum_Load(object sender, EventArgs e)
        {
            string query = "Select Codigo, Nombre, Requisito, UV From Materias Where ID = " + carrera;
            SqlCommand command = new SqlCommand(query, Conexion.obtenerconexion());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Materia materia = new Materia();
                materia.Codigo = (string)reader["Codigo"];
                materia.Nombre = (string)reader["Nombre"];
                try
                {
                    materia.prerequisito = (string)reader["Requisito"];
                }
                catch
                {

                }
                materia.uv = (int)reader["UV"];
                materiasC.Add(materia);
            }
            Materia[] impr = materiasC.CopyToArray();
            dgvPensum.DataSource = impr;
            foreach (DataGridViewColumn column in dgvPensum.Columns.Cast<DataGridViewColumn>().ToArray())
            {
                bool allEmpty = true;
                bool containsZero = false;
                foreach (DataGridViewRow row in dgvPensum.Rows)
                {
                    if (!row.IsNewRow && !string.IsNullOrEmpty(row.Cells[column.Index].FormattedValue.ToString()))
                    {
                        allEmpty = false;
                        if (row.Cells[column.Index].Value.ToString() == "0")
                        {
                            containsZero = true;
                            break;
                        }
                    }
                }
                if (allEmpty || containsZero)
                {
                    dgvPensum.Columns.Remove(column);
                }
            }
            dgvPensum.Refresh();
        }

        private void dgvPensum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
