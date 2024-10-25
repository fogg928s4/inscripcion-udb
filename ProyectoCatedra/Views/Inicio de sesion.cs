using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
/*Alberto Ramos Cruz - RC220772
Roberto José Melgares Zelaya - MZ221682
René Eduardo Hernández Castro - HC220857
Oscar Edgardo Navarro Banderas - NB220557
Fernando José Aquino Valle - AV220672*/
namespace ProyectoCatedra
{
    public partial class frminiciodesesion : Form
    {
        MateriaCola cola = new MateriaCola();
        public frminiciodesesion()
        {
            InitializeComponent();
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {

            if (txtusuario.Text == "N° de Carnet")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "N° de Carnet";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            frmportal back = new frmportal();
            this.Hide();
            back.ShowDialog();
            this.Close();
        }

        /*Aquí compartimos un usuario de tipo administrador:
     Carnet: 123456
     Contraseña: rene
     Y a continuación un usuario de tipo estudiante:
     carnet: VV981775
     contraseña: vicente
     Si quiere ingresar usuarios distintos revise el script de la base de datos adjuntada con este programa.
     */
        public void btningresar_Click(object sender, EventArgs e)
        {
            /* Se verifica y valida que el usuario sea válido, luego se abre la vista de alumno
             * o admninistrador según rol de usuario.
             */
            FormAdmin opne1 = new FormAdmin();
            Estudiante usuario = new Estudiante();
            if (!Regex.IsMatch(txtusuario.Text, @"^[a-zA-Z0-9]*$"))
            {
                MessageBox.Show("El carnet está en un formato no válido.");
                txtusuario.Focus();
            }
            else
            {
                try
                {
                    usuario.Carnet = txtusuario.Text.ToUpper();
                    usuario.Contraseña = txtpass.Text;
                    VerificarLogin cmd = new VerificarLogin();
                    bool resu = cmd.Login(usuario.Carnet, usuario.Contraseña);
                    if (resu == true)
                    {
                        try
                        {
                            Convert.ToInt32(usuario.Carnet);
                            this.Hide();
                            opne1.ShowDialog();
                            this.Close();
                        }
                        catch
                        {
                            string query = "SELECT * FROM Usuario WHERE Usuario = '" + usuario.Carnet + "'";
                            SqlCommand command = new SqlCommand(query, Conexion.obtenerconexion());
                            SqlDataReader reader = command.ExecuteReader();
                            Estudiante estudiantelogin = new Estudiante();

                            if (reader.Read())
                            {
                                PerfilDatoscs a = new PerfilDatoscs();
                                estudiantelogin.Carnet = (string)reader["Usuario"];
                                estudiantelogin.Nombre = (string)reader["Nombres"];
                                estudiantelogin.Apellido = (string)reader["Apellidos"];
                                estudiantelogin.Nacimiento = (string)reader["Nacimiento"];
                                estudiantelogin.Email = (string)reader["Email"];
                                estudiantelogin.Telefono = (string)reader["Telefono"];
                                estudiantelogin.Direccion = (string)reader["Direccion"];
                                estudiantelogin.Dui = (string)reader["Dui"];
                                estudiantelogin.Carrera = (int)reader["ID"];
                                estudiantelogin.Sexo = (string)reader["SEXO"];
                                MateriaList listaA = new MateriaList();
                                MateriaList ListaB = new MateriaList();
                                Obtener_materias materias = new Obtener_materias();
                                listaA = materias.MatariasCurs(usuario.Carnet);
                                ListaB = materias.materiasp(usuario.Carnet);
                                a.Carrera = estudiantelogin.Carrera;
                                frminicio open = new frminicio(estudiantelogin, listaA, ListaB, cola);
                                this.Hide();
                                open.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Usuario no encontrado", "Lo sentimos...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar, intente nuevamente");
                        txtpass.Text = "Contraseña";
                        txtusuario.Text = "Usuario";
                    }
                }
                catch
                {
                    MessageBox.Show("Error al establecer conexión con la base de datos. Por favor, revise que el host coincida con el de su equipo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = !txtpass.UseSystemPasswordChar;
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
            else if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            //txtusuario.Text = txtusuario.Text.ToUpper();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
