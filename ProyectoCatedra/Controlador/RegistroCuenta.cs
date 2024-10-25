using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoCatedra.Clases;
using ProyectoCatedra.Controlador;

namespace ProyectoCatedra.Controlador
{
    //esta clase ayuda a registrar la información del usuario después de registrarse
    public class RegistroCuenta
    {
        public static int Registrar(Estudiante con)
        {
            int retorno = 0;
            try
            {
                //Se crea la querry para insertar todos los datos dentro de la base de datos 
                SqlCommand cmdAdd = new SqlCommand(string.Format(" INSERT INTO  Usuario (Usuario, Nombres, Apellidos, Nacimiento, Email, Telefono, Direccion, DUI, contraseña, ID, SEXO )" +
                    "                                                 Values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}' ) ", 
                                                                      con.Carnet, con.Nombre, con.Apellido, con.Nacimiento, con.Email, con.Telefono, con.Direccion, con.Dui, con.Contraseña, con.Carrera,con.Sexo),  Conexion.obtenerconexion());
                //Retorno verifica que se afectaron lineas durante el insert, es decir que el insert pudo ser ejecutado sin problemas
                retorno = Convert.ToInt16(cmdAdd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("Los datos han sido ingresados correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    MessageBox.Show("Los datos no se han podido ingresar", "error en el envío de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;

            }
            //En caso de que las lineas afectadas den erros, se hace un catch para evitar el colapso del sistema
            catch (Exception e)
            {
                MessageBox.Show("Algo ocurrio durante la insercion " + e, "Su registro no es valido " , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}
