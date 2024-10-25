using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Windows.Forms;

namespace ProyectoCatedra
{
    //Clase que permite establecer la conexion con la base de datos
    class Conexion
    {
        public static SqlConnection obtenerconexion()
        {
            SqlConnection connect;
            string server = "DESKTOP-6998V8O\\SQLEXPRESS"; //Si no funciona cambiar el nombre del servidor, por el que aparazca en su maquina. Defaul: localhost
            string database = "Test";

            try
            {
                //Esta es la cadena de conexion, donde ser manda a llamar la conexion con el servidor y la base de datos predefinida
                connect = new SqlConnection("server = " + server +
                                              "; database =" + database +
                                              "; integrated security = true");
                connect.Open();
                return connect;
            }
            catch (Exception e)
            {
                 MessageBox.Show("Error critico de conexión: " + e, "Fallo de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return connect = new SqlConnection();
                return null;
            }
        }
    }
}
