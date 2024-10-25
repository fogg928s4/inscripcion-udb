using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCatedra
{
    //Crea objetos para cargar dentro de perfil
    internal class PerfilDatoscs
    {
        //Este sera un nodo de para cargar datos dentro del perfil
        public PerfilDatoscs()
        {

        }
        public int Carrera { get; set; }

        public string Usuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Nacimiento { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string DUI { get; set; }
        public string Contraseña { get; set; }
        public int ID { get; set; }
    }
}
