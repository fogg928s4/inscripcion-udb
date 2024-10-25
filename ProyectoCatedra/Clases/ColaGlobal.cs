using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoCatedra.Clases;
using ProyectoCatedra.Controlador;

namespace ProyectoCatedra.Clases
{
    public static class ColaGlobal
    {
        /// <summary>
        /// Esta cola global, permite poder ocupar la cola en diferentes forms, evitando errores de null y haciendo mas dinamico 
        /// el manejar la cola en el programa
        /// </summary>
        public static ColaInscripcion colainscripcion;
        public static ColaInscripcion Colainscripcion
        {
            get { return colainscripcion; }
            set { colainscripcion = value; }
        }
        static ColaGlobal()
        {
            colainscripcion = new ColaInscripcion();
        }

    }
}
