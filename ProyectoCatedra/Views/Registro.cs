using ProyectoCatedra.Controlador;
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
/*Alberto Ramos Cruz - RC220772
Roberto José Melgares Zelaya - MZ221682
René Eduardo Hernández Castro - HC220857
Oscar Edgardo Navarro Banderas - NB220557
Fernando José Aquino Valle - AV220672*/

namespace ProyectoCatedra
{
    public partial class frmregistro : Form
    {
        public ListaEstudiantes EstudiantesL = new ListaEstudiantes();
        public Estudiante r = new Estudiante();
        DateTime minDate = new DateTime(2006, 1, 1);
        DateTime maxDate = DateTime.Now.AddYears(-30);
        public frmregistro()
        {
            InitializeComponent();
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmportal regresar = new frmportal();
            this.Hide();
            regresar.ShowDialog();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the email has the correct format
            if (txtContraseña.Text == "" || txtApellido.Text == "" || txtContraseña.Text == "" ||
            txtDireccion.Text == "" || comboBoxsexo.Text == "" || txtDui.Text == "" ||
            txtEmail.Text == "" || CmbCarrera.Text == "" || txtFecha.Text == "" ||
            txtNombre.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Complete los campos vacios.");
                txtNombre.Focus();
            }
            else if ((txtFecha.Value < maxDate || txtFecha.Value > minDate))
            {
                MessageBox.Show("Por favor, seleccionar una fecha entre " + maxDate.ToShortDateString() +
                    " y " + minDate.ToShortDateString() + ".");
                txtFecha.Value = maxDate;
                txtFecha.Focus();
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^.*@.*\.com$"))
            {
                MessageBox.Show("Ingresar correo eléctronico válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
            else if (txtContraseña.Text.Length < 4)
            {
                MessageBox.Show("Contraseña poco segura. Debe poseer más de 4 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();
            }
            else
            {
                // Obtener las dos primeras letras de las TextBox
                string letra1 = txtNombre.Text.Length >= 2 ? txtNombre.Text.Substring(0, 1).ToUpper() : "";
                string letra2 = txtApellido.Text.Length >= 2 ? txtApellido.Text.Substring(0, 1).ToUpper() : "";

                // Generar 6 números aleatorios
                Random random = new Random();
                string numeros = "";
                for (int i = 0; i < 6; i++)
                {
                    numeros += random.Next(0, 10).ToString();
                }

                // Crear el string final
                string resultado = letra1 + letra2 + numeros;
                MessageBox.Show("Registro agregado correctamente" + "\n\n" + "Tu carnet es: " + resultado);
                r.Nombre = txtNombre.Text;
                r.Apellido = txtApellido.Text;
                r.Nacimiento = txtFecha.Text;
                r.Telefono = txtTelefono.Text;
                r.Email = txtEmail.Text;
                r.Direccion = txtDireccion.Text;
                r.Dui = txtDui.Text;
                if (comboBoxsexo.SelectedIndex == 0)
                {
                    r.Sexo = "Masculino";
                }
                else
                {
                    r.Sexo = "Femenino";
                }
                if (CmbCarrera.Text == "Ingenieria en Sistemas")
                {
                    r.Carrera = 1;
                }
                else if (CmbCarrera.Text == "Licenciatura en Informatica")
                {
                    r.Carrera = 2;
                }
                else if (CmbCarrera.Text == "Licenciatura en Diseño Gráfico")
                {
                    r.Carrera = 3;
                }
                else if (CmbCarrera.Text == "Ingeniería en Telecomunicaciones")
                {
                    r.Carrera = 4;
                }

                r.Contraseña = txtContraseña.Text;
                r.Carnet = resultado;

                EstudiantesL.InsertarI(r);
                EstudiantesL = null;

                frmportal cerrar = new frmportal();
                this.Hide();
                cerrar.ShowDialog();
                this.Close();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
            else if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se aceptan letras", "ERROR");
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
            else if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se aceptan letras", "ERROR");
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se aceptan números");
                e.Handled = true;
            }
        }

        private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se aceptan números");
                e.Handled = true;
            }
        }
        private void txtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void CmbCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void comboBoxsexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !txtContraseña.UseSystemPasswordChar;
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (ValidateEmail(txtEmail.Text)) { }
            //si es correcto no debe hacer nada
            else
            {
                MessageBox.Show("Dirección de correo no válida", "Validación de correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Clear(); // selecciona todo lo de la casilla 
                txtEmail.Focus();
            }
        }
        public bool ValidateEmail(string pEmail)
        {
            //cadena o expresion regular que verifica a un formato de correo electrónico
            var expression = @"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$";

            if (Regex.IsMatch(pEmail, expression))
            {
                //verifica que la direccion corresponda y que la longitud de la cadena no esté vacía
                if (Regex.Replace(pEmail, expression, string.Empty).Length == 0)
                    return true;
                return false;
            }
            return false;
        }

        private void txtTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
