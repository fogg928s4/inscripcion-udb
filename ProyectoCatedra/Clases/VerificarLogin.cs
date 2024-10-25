using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoCatedra
{
    //Esta clase es importante para poder autenticar los login a la base de datos
    public class VerificarLogin
    {
        public bool Login(string usuario, string constraseña)
        {
            string aux = constraseña;
            string aux1 = usuario;
            //Se crea un comando de sql con los parametros y la querry para verificar que tanto el usuario como la contraseña existan dentro de la base de datos
            SqlCommand cmdAdd = new SqlCommand(string.Format("SELECT Usuario from Usuario Where Usuario = '" + aux1 + "' AND contraseña = '" + aux + "'"), Conexion.obtenerconexion());
            SqlDataReader reader = cmdAdd.ExecuteReader();
            if (reader.HasRows)//En este if se verifica que la consulta devolvio resultados, es decir que existen los datos en la base de datos
            {
                Console.WriteLine("La consulta se ejecutó correctamente");
                return true;
            }
            else
            {
               Console.WriteLine("La consulta no devolvió ningún resultado");
                return false;
            }
        }
    }
}
